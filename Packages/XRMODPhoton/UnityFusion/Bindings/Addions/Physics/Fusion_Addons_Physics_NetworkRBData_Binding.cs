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
    unsafe class Fusion_Addons_Physics_NetworkRBData_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.Physics.NetworkRBData);
            args = new Type[]{};
            method = type.GetMethod("get_Flags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Flags_0);
            args = new Type[]{typeof(System.ValueTuple<Fusion.Addons.Physics.NetworkRigidbodyFlags, System.Int32>)};
            method = type.GetMethod("set_Flags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Flags_1);
            args = new Type[]{};
            method = type.GetMethod("get_LinearVelocity2D", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_LinearVelocity2D_2);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("set_LinearVelocity2D", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_LinearVelocity2D_3);
            args = new Type[]{};
            method = type.GetMethod("get_AngularVelocity2D", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_AngularVelocity2D_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_AngularVelocity2D", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_AngularVelocity2D_5);
            args = new Type[]{};
            method = type.GetMethod("get_GravityScale2D", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GravityScale2D_6);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_GravityScale2D", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_GravityScale2D_7);

            field = type.GetField("WORDS", flag);
            app.RegisterCLRFieldGetter(field, get_WORDS_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_WORDS_0, null);
            field = type.GetField("SIZE", flag);
            app.RegisterCLRFieldGetter(field, get_SIZE_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_SIZE_1, null);
            field = type.GetField("TRSPData", flag);
            app.RegisterCLRFieldGetter(field, get_TRSPData_2);
            app.RegisterCLRFieldSetter(field, set_TRSPData_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_TRSPData_2, AssignFromStack_TRSPData_2);
            field = type.GetField("Drag", flag);
            app.RegisterCLRFieldGetter(field, get_Drag_3);
            app.RegisterCLRFieldSetter(field, set_Drag_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Drag_3, AssignFromStack_Drag_3);
            field = type.GetField("AngularDrag", flag);
            app.RegisterCLRFieldGetter(field, get_AngularDrag_4);
            app.RegisterCLRFieldSetter(field, set_AngularDrag_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_AngularDrag_4, AssignFromStack_AngularDrag_4);
            field = type.GetField("Mass", flag);
            app.RegisterCLRFieldGetter(field, get_Mass_5);
            app.RegisterCLRFieldSetter(field, set_Mass_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_Mass_5, AssignFromStack_Mass_5);
            field = type.GetField("LinearVelocity", flag);
            app.RegisterCLRFieldGetter(field, get_LinearVelocity_6);
            app.RegisterCLRFieldSetter(field, set_LinearVelocity_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_LinearVelocity_6, AssignFromStack_LinearVelocity_6);
            field = type.GetField("AngularVelocity", flag);
            app.RegisterCLRFieldGetter(field, get_AngularVelocity_7);
            app.RegisterCLRFieldSetter(field, set_AngularVelocity_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_AngularVelocity_7, AssignFromStack_AngularVelocity_7);
            field = type.GetField("FullPrecisionPosition", flag);
            app.RegisterCLRFieldGetter(field, get_FullPrecisionPosition_8);
            app.RegisterCLRFieldSetter(field, set_FullPrecisionPosition_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_FullPrecisionPosition_8, AssignFromStack_FullPrecisionPosition_8);
            field = type.GetField("FullPrecisionRotation", flag);
            app.RegisterCLRFieldGetter(field, get_FullPrecisionRotation_9);
            app.RegisterCLRFieldSetter(field, set_FullPrecisionRotation_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_FullPrecisionRotation_9, AssignFromStack_FullPrecisionRotation_9);
            field = type.GetField("TeleportPosition", flag);
            app.RegisterCLRFieldGetter(field, get_TeleportPosition_10);
            app.RegisterCLRFieldSetter(field, set_TeleportPosition_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_TeleportPosition_10, AssignFromStack_TeleportPosition_10);
            field = type.GetField("TeleportRotation", flag);
            app.RegisterCLRFieldGetter(field, get_TeleportRotation_11);
            app.RegisterCLRFieldSetter(field, set_TeleportRotation_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_TeleportRotation_11, AssignFromStack_TeleportRotation_11);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.Physics.NetworkRBData());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.Physics.NetworkRBData[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Fusion.Addons.Physics.NetworkRBData instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Fusion.Addons.Physics.NetworkRBData[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* get_Flags_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Fusion.Addons.Physics.NetworkRBData instance_of_this_method = (Fusion.Addons.Physics.NetworkRBData)typeof(Fusion.Addons.Physics.NetworkRBData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.Flags;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_Flags_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.ValueTuple<Fusion.Addons.Physics.NetworkRigidbodyFlags, System.Int32> @value = (System.ValueTuple<Fusion.Addons.Physics.NetworkRigidbodyFlags, System.Int32>)typeof(System.ValueTuple<Fusion.Addons.Physics.NetworkRigidbodyFlags, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Fusion.Addons.Physics.NetworkRBData instance_of_this_method = (Fusion.Addons.Physics.NetworkRBData)typeof(Fusion.Addons.Physics.NetworkRBData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            instance_of_this_method.Flags = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* get_LinearVelocity2D_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Fusion.Addons.Physics.NetworkRBData instance_of_this_method = (Fusion.Addons.Physics.NetworkRBData)typeof(Fusion.Addons.Physics.NetworkRBData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.LinearVelocity2D;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_LinearVelocity2D_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @value = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Fusion.Addons.Physics.NetworkRBData instance_of_this_method = (Fusion.Addons.Physics.NetworkRBData)typeof(Fusion.Addons.Physics.NetworkRBData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            instance_of_this_method.LinearVelocity2D = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* get_AngularVelocity2D_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Fusion.Addons.Physics.NetworkRBData instance_of_this_method = (Fusion.Addons.Physics.NetworkRBData)typeof(Fusion.Addons.Physics.NetworkRBData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.AngularVelocity2D;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_AngularVelocity2D_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Fusion.Addons.Physics.NetworkRBData instance_of_this_method = (Fusion.Addons.Physics.NetworkRBData)typeof(Fusion.Addons.Physics.NetworkRBData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            instance_of_this_method.AngularVelocity2D = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* get_GravityScale2D_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Fusion.Addons.Physics.NetworkRBData instance_of_this_method = (Fusion.Addons.Physics.NetworkRBData)typeof(Fusion.Addons.Physics.NetworkRBData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.GravityScale2D;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_GravityScale2D_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Fusion.Addons.Physics.NetworkRBData instance_of_this_method = (Fusion.Addons.Physics.NetworkRBData)typeof(Fusion.Addons.Physics.NetworkRBData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            instance_of_this_method.GravityScale2D = value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }


        static object get_WORDS_0(ref object o)
        {
            return Fusion.Addons.Physics.NetworkRBData.WORDS;
        }

        static StackObject* CopyToStack_WORDS_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.Physics.NetworkRBData.WORDS;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_SIZE_1(ref object o)
        {
            return Fusion.Addons.Physics.NetworkRBData.SIZE;
        }

        static StackObject* CopyToStack_SIZE_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.Physics.NetworkRBData.SIZE;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_TRSPData_2(ref object o)
        {
            return ((Fusion.Addons.Physics.NetworkRBData)o).TRSPData;
        }

        static StackObject* CopyToStack_TRSPData_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.Physics.NetworkRBData)o).TRSPData;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TRSPData_2(ref object o, object v)
        {
            Fusion.Addons.Physics.NetworkRBData ins =(Fusion.Addons.Physics.NetworkRBData)o;
            ins.TRSPData = (Fusion.NetworkTRSPData)v;
            o = ins;
        }

        static StackObject* AssignFromStack_TRSPData_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.NetworkTRSPData @TRSPData = (Fusion.NetworkTRSPData)typeof(Fusion.NetworkTRSPData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Fusion.Addons.Physics.NetworkRBData ins =(Fusion.Addons.Physics.NetworkRBData)o;
            ins.TRSPData = @TRSPData;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Drag_3(ref object o)
        {
            return ((Fusion.Addons.Physics.NetworkRBData)o).Drag;
        }

        static StackObject* CopyToStack_Drag_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.Physics.NetworkRBData)o).Drag;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Drag_3(ref object o, object v)
        {
            Fusion.Addons.Physics.NetworkRBData ins =(Fusion.Addons.Physics.NetworkRBData)o;
            ins.Drag = (Fusion.FloatCompressed)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Drag_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.FloatCompressed @Drag = (Fusion.FloatCompressed)typeof(Fusion.FloatCompressed).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Fusion.Addons.Physics.NetworkRBData ins =(Fusion.Addons.Physics.NetworkRBData)o;
            ins.Drag = @Drag;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_AngularDrag_4(ref object o)
        {
            return ((Fusion.Addons.Physics.NetworkRBData)o).AngularDrag;
        }

        static StackObject* CopyToStack_AngularDrag_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.Physics.NetworkRBData)o).AngularDrag;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AngularDrag_4(ref object o, object v)
        {
            Fusion.Addons.Physics.NetworkRBData ins =(Fusion.Addons.Physics.NetworkRBData)o;
            ins.AngularDrag = (Fusion.FloatCompressed)v;
            o = ins;
        }

        static StackObject* AssignFromStack_AngularDrag_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.FloatCompressed @AngularDrag = (Fusion.FloatCompressed)typeof(Fusion.FloatCompressed).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Fusion.Addons.Physics.NetworkRBData ins =(Fusion.Addons.Physics.NetworkRBData)o;
            ins.AngularDrag = @AngularDrag;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Mass_5(ref object o)
        {
            return ((Fusion.Addons.Physics.NetworkRBData)o).Mass;
        }

        static StackObject* CopyToStack_Mass_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.Physics.NetworkRBData)o).Mass;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Mass_5(ref object o, object v)
        {
            Fusion.Addons.Physics.NetworkRBData ins =(Fusion.Addons.Physics.NetworkRBData)o;
            ins.Mass = (Fusion.FloatCompressed)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Mass_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.FloatCompressed @Mass = (Fusion.FloatCompressed)typeof(Fusion.FloatCompressed).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Fusion.Addons.Physics.NetworkRBData ins =(Fusion.Addons.Physics.NetworkRBData)o;
            ins.Mass = @Mass;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_LinearVelocity_6(ref object o)
        {
            return ((Fusion.Addons.Physics.NetworkRBData)o).LinearVelocity;
        }

        static StackObject* CopyToStack_LinearVelocity_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.Physics.NetworkRBData)o).LinearVelocity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LinearVelocity_6(ref object o, object v)
        {
            Fusion.Addons.Physics.NetworkRBData ins =(Fusion.Addons.Physics.NetworkRBData)o;
            ins.LinearVelocity = (Fusion.Vector3Compressed)v;
            o = ins;
        }

        static StackObject* AssignFromStack_LinearVelocity_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Vector3Compressed @LinearVelocity = (Fusion.Vector3Compressed)typeof(Fusion.Vector3Compressed).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Fusion.Addons.Physics.NetworkRBData ins =(Fusion.Addons.Physics.NetworkRBData)o;
            ins.LinearVelocity = @LinearVelocity;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_AngularVelocity_7(ref object o)
        {
            return ((Fusion.Addons.Physics.NetworkRBData)o).AngularVelocity;
        }

        static StackObject* CopyToStack_AngularVelocity_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.Physics.NetworkRBData)o).AngularVelocity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AngularVelocity_7(ref object o, object v)
        {
            Fusion.Addons.Physics.NetworkRBData ins =(Fusion.Addons.Physics.NetworkRBData)o;
            ins.AngularVelocity = (Fusion.Vector3Compressed)v;
            o = ins;
        }

        static StackObject* AssignFromStack_AngularVelocity_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Vector3Compressed @AngularVelocity = (Fusion.Vector3Compressed)typeof(Fusion.Vector3Compressed).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Fusion.Addons.Physics.NetworkRBData ins =(Fusion.Addons.Physics.NetworkRBData)o;
            ins.AngularVelocity = @AngularVelocity;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_FullPrecisionPosition_8(ref object o)
        {
            return ((Fusion.Addons.Physics.NetworkRBData)o).FullPrecisionPosition;
        }

        static StackObject* CopyToStack_FullPrecisionPosition_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.Physics.NetworkRBData)o).FullPrecisionPosition;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_FullPrecisionPosition_8(ref object o, object v)
        {
            Fusion.Addons.Physics.NetworkRBData ins =(Fusion.Addons.Physics.NetworkRBData)o;
            ins.FullPrecisionPosition = (UnityEngine.Vector3)v;
            o = ins;
        }

        static StackObject* AssignFromStack_FullPrecisionPosition_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @FullPrecisionPosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Fusion.Addons.Physics.NetworkRBData ins =(Fusion.Addons.Physics.NetworkRBData)o;
            ins.FullPrecisionPosition = @FullPrecisionPosition;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_FullPrecisionRotation_9(ref object o)
        {
            return ((Fusion.Addons.Physics.NetworkRBData)o).FullPrecisionRotation;
        }

        static StackObject* CopyToStack_FullPrecisionRotation_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.Physics.NetworkRBData)o).FullPrecisionRotation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_FullPrecisionRotation_9(ref object o, object v)
        {
            Fusion.Addons.Physics.NetworkRBData ins =(Fusion.Addons.Physics.NetworkRBData)o;
            ins.FullPrecisionRotation = (UnityEngine.Quaternion)v;
            o = ins;
        }

        static StackObject* AssignFromStack_FullPrecisionRotation_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Quaternion @FullPrecisionRotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Fusion.Addons.Physics.NetworkRBData ins =(Fusion.Addons.Physics.NetworkRBData)o;
            ins.FullPrecisionRotation = @FullPrecisionRotation;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_TeleportPosition_10(ref object o)
        {
            return ((Fusion.Addons.Physics.NetworkRBData)o).TeleportPosition;
        }

        static StackObject* CopyToStack_TeleportPosition_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.Physics.NetworkRBData)o).TeleportPosition;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TeleportPosition_10(ref object o, object v)
        {
            Fusion.Addons.Physics.NetworkRBData ins =(Fusion.Addons.Physics.NetworkRBData)o;
            ins.TeleportPosition = (Fusion.Vector3Compressed)v;
            o = ins;
        }

        static StackObject* AssignFromStack_TeleportPosition_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Vector3Compressed @TeleportPosition = (Fusion.Vector3Compressed)typeof(Fusion.Vector3Compressed).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Fusion.Addons.Physics.NetworkRBData ins =(Fusion.Addons.Physics.NetworkRBData)o;
            ins.TeleportPosition = @TeleportPosition;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_TeleportRotation_11(ref object o)
        {
            return ((Fusion.Addons.Physics.NetworkRBData)o).TeleportRotation;
        }

        static StackObject* CopyToStack_TeleportRotation_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.Physics.NetworkRBData)o).TeleportRotation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TeleportRotation_11(ref object o, object v)
        {
            Fusion.Addons.Physics.NetworkRBData ins =(Fusion.Addons.Physics.NetworkRBData)o;
            ins.TeleportRotation = (Fusion.QuaternionCompressed)v;
            o = ins;
        }

        static StackObject* AssignFromStack_TeleportRotation_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.QuaternionCompressed @TeleportRotation = (Fusion.QuaternionCompressed)typeof(Fusion.QuaternionCompressed).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Fusion.Addons.Physics.NetworkRBData ins =(Fusion.Addons.Physics.NetworkRBData)o;
            ins.TeleportRotation = @TeleportRotation;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Fusion.Addons.Physics.NetworkRBData();
            ins = (Fusion.Addons.Physics.NetworkRBData)o;
            return ins;
        }


    }
}
#endif
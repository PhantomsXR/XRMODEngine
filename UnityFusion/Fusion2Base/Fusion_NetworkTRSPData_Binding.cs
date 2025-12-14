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
    unsafe class Fusion_NetworkTRSPData_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.NetworkTRSPData);
            args = new Type[]{};
            method = type.GetMethod("get_NonNetworkedParent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_NonNetworkedParent_0);

            field = type.GetField("WORDS", flag);
            app.RegisterCLRFieldGetter(field, get_WORDS_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_WORDS_0, null);
            field = type.GetField("SIZE", flag);
            app.RegisterCLRFieldGetter(field, get_SIZE_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_SIZE_1, null);
            field = type.GetField("POSITION_OFFSET", flag);
            app.RegisterCLRFieldGetter(field, get_POSITION_OFFSET_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_POSITION_OFFSET_2, null);
            field = type.GetField("Parent", flag);
            app.RegisterCLRFieldGetter(field, get_Parent_3);
            app.RegisterCLRFieldSetter(field, set_Parent_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Parent_3, AssignFromStack_Parent_3);
            field = type.GetField("Position", flag);
            app.RegisterCLRFieldGetter(field, get_Position_4);
            app.RegisterCLRFieldSetter(field, set_Position_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Position_4, AssignFromStack_Position_4);
            field = type.GetField("Rotation", flag);
            app.RegisterCLRFieldGetter(field, get_Rotation_5);
            app.RegisterCLRFieldSetter(field, set_Rotation_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_Rotation_5, AssignFromStack_Rotation_5);
            field = type.GetField("Scale", flag);
            app.RegisterCLRFieldGetter(field, get_Scale_6);
            app.RegisterCLRFieldSetter(field, set_Scale_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_Scale_6, AssignFromStack_Scale_6);
            field = type.GetField("TeleportKey", flag);
            app.RegisterCLRFieldGetter(field, get_TeleportKey_7);
            app.RegisterCLRFieldSetter(field, set_TeleportKey_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_TeleportKey_7, AssignFromStack_TeleportKey_7);
            field = type.GetField("AreaOfInterestOverride", flag);
            app.RegisterCLRFieldGetter(field, get_AreaOfInterestOverride_8);
            app.RegisterCLRFieldSetter(field, set_AreaOfInterestOverride_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_AreaOfInterestOverride_8, AssignFromStack_AreaOfInterestOverride_8);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.NetworkTRSPData());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.NetworkTRSPData[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Fusion.NetworkTRSPData instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Fusion.NetworkTRSPData[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* get_NonNetworkedParent_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Fusion.NetworkTRSPData.NonNetworkedParent;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_WORDS_0(ref object o)
        {
            return Fusion.NetworkTRSPData.WORDS;
        }

        static StackObject* CopyToStack_WORDS_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.NetworkTRSPData.WORDS;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_SIZE_1(ref object o)
        {
            return Fusion.NetworkTRSPData.SIZE;
        }

        static StackObject* CopyToStack_SIZE_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.NetworkTRSPData.SIZE;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_POSITION_OFFSET_2(ref object o)
        {
            return Fusion.NetworkTRSPData.POSITION_OFFSET;
        }

        static StackObject* CopyToStack_POSITION_OFFSET_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.NetworkTRSPData.POSITION_OFFSET;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_Parent_3(ref object o)
        {
            return ((Fusion.NetworkTRSPData)o).Parent;
        }

        static StackObject* CopyToStack_Parent_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.NetworkTRSPData)o).Parent;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Parent_3(ref object o, object v)
        {
            Fusion.NetworkTRSPData ins =(Fusion.NetworkTRSPData)o;
            ins.Parent = (Fusion.NetworkBehaviourId)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Parent_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.NetworkBehaviourId @Parent = (Fusion.NetworkBehaviourId)typeof(Fusion.NetworkBehaviourId).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Fusion.NetworkTRSPData ins =(Fusion.NetworkTRSPData)o;
            ins.Parent = @Parent;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Position_4(ref object o)
        {
            return ((Fusion.NetworkTRSPData)o).Position;
        }

        static StackObject* CopyToStack_Position_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.NetworkTRSPData)o).Position;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Position_4(ref object o, object v)
        {
            Fusion.NetworkTRSPData ins =(Fusion.NetworkTRSPData)o;
            ins.Position = (UnityEngine.Vector3)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Position_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @Position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Fusion.NetworkTRSPData ins =(Fusion.NetworkTRSPData)o;
            ins.Position = @Position;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Rotation_5(ref object o)
        {
            return ((Fusion.NetworkTRSPData)o).Rotation;
        }

        static StackObject* CopyToStack_Rotation_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.NetworkTRSPData)o).Rotation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Rotation_5(ref object o, object v)
        {
            Fusion.NetworkTRSPData ins =(Fusion.NetworkTRSPData)o;
            ins.Rotation = (UnityEngine.Quaternion)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Rotation_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Quaternion @Rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Fusion.NetworkTRSPData ins =(Fusion.NetworkTRSPData)o;
            ins.Rotation = @Rotation;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Scale_6(ref object o)
        {
            return ((Fusion.NetworkTRSPData)o).Scale;
        }

        static StackObject* CopyToStack_Scale_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.NetworkTRSPData)o).Scale;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Scale_6(ref object o, object v)
        {
            Fusion.NetworkTRSPData ins =(Fusion.NetworkTRSPData)o;
            ins.Scale = (Fusion.Vector3Compressed)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Scale_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Vector3Compressed @Scale = (Fusion.Vector3Compressed)typeof(Fusion.Vector3Compressed).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Fusion.NetworkTRSPData ins =(Fusion.NetworkTRSPData)o;
            ins.Scale = @Scale;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_TeleportKey_7(ref object o)
        {
            return ((Fusion.NetworkTRSPData)o).TeleportKey;
        }

        static StackObject* CopyToStack_TeleportKey_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.NetworkTRSPData)o).TeleportKey;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_TeleportKey_7(ref object o, object v)
        {
            Fusion.NetworkTRSPData ins =(Fusion.NetworkTRSPData)o;
            ins.TeleportKey = (System.Int32)v;
            o = ins;
        }

        static StackObject* AssignFromStack_TeleportKey_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @TeleportKey = ptr_of_this_method->Value;
            Fusion.NetworkTRSPData ins =(Fusion.NetworkTRSPData)o;
            ins.TeleportKey = @TeleportKey;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_AreaOfInterestOverride_8(ref object o)
        {
            return ((Fusion.NetworkTRSPData)o).AreaOfInterestOverride;
        }

        static StackObject* CopyToStack_AreaOfInterestOverride_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.NetworkTRSPData)o).AreaOfInterestOverride;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AreaOfInterestOverride_8(ref object o, object v)
        {
            Fusion.NetworkTRSPData ins =(Fusion.NetworkTRSPData)o;
            ins.AreaOfInterestOverride = (Fusion.NetworkId)v;
            o = ins;
        }

        static StackObject* AssignFromStack_AreaOfInterestOverride_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.NetworkId @AreaOfInterestOverride = (Fusion.NetworkId)typeof(Fusion.NetworkId).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Fusion.NetworkTRSPData ins =(Fusion.NetworkTRSPData)o;
            ins.AreaOfInterestOverride = @AreaOfInterestOverride;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Fusion.NetworkTRSPData();
            ins = (Fusion.NetworkTRSPData)o;
            return ins;
        }


    }
}

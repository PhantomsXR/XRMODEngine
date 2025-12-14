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
    unsafe class Unity_Netcode_NetworkVariableBase_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Netcode.NetworkVariableBase);
            args = new Type[]{};
            method = type.GetMethod("GetBehaviour", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetBehaviour_0);
            args = new Type[]{typeof(Unity.Netcode.NetworkBehaviour)};
            method = type.GetMethod("Initialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Initialize_1);
            args = new Type[]{};
            method = type.GetMethod("OnInitialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnInitialize_2);
            args = new Type[]{typeof(Unity.Netcode.NetworkVariableUpdateTraits)};
            method = type.GetMethod("SetUpdateTraits", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetUpdateTraits_3);
            args = new Type[]{};
            method = type.GetMethod("ExceedsDirtinessThreshold", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ExceedsDirtinessThreshold_4);
            args = new Type[]{};
            method = type.GetMethod("get_Name", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Name_5);
            args = new Type[]{};
            method = type.GetMethod("get_WritePerm", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_WritePerm_6);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("SetDirty", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetDirty_7);
            args = new Type[]{};
            method = type.GetMethod("ResetDirty", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResetDirty_8);
            args = new Type[]{};
            method = type.GetMethod("IsDirty", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsDirty_9);
            args = new Type[]{typeof(System.UInt64)};
            method = type.GetMethod("CanClientRead", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CanClientRead_10);
            args = new Type[]{typeof(System.UInt64)};
            method = type.GetMethod("CanClientWrite", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CanClientWrite_11);
            args = new Type[]{typeof(Unity.Netcode.FastBufferWriter)};
            method = type.GetMethod("WriteDelta", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteDelta_12);
            args = new Type[]{typeof(Unity.Netcode.FastBufferWriter)};
            method = type.GetMethod("WriteField", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteField_13);
            args = new Type[]{typeof(Unity.Netcode.FastBufferReader)};
            method = type.GetMethod("ReadField", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReadField_14);
            args = new Type[]{typeof(Unity.Netcode.FastBufferReader), typeof(System.Boolean)};
            method = type.GetMethod("ReadDelta", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReadDelta_15);
            args = new Type[]{};
            method = type.GetMethod("Dispose", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Dispose_16);

            field = type.GetField("DefaultReadPerm", flag);
            app.RegisterCLRFieldGetter(field, get_DefaultReadPerm_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_DefaultReadPerm_0, null);
            field = type.GetField("DefaultWritePerm", flag);
            app.RegisterCLRFieldGetter(field, get_DefaultWritePerm_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_DefaultWritePerm_1, null);
            field = type.GetField("ReadPerm", flag);
            app.RegisterCLRFieldGetter(field, get_ReadPerm_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_ReadPerm_2, null);


            app.RegisterCLRCreateArrayInstance(type, s => new Unity.Netcode.NetworkVariableBase[s]);


        }


        static StackObject* GetBehaviour_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkVariableBase instance_of_this_method = (Unity.Netcode.NetworkVariableBase)typeof(Unity.Netcode.NetworkVariableBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetBehaviour();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Initialize_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkBehaviour @networkBehaviour = (Unity.Netcode.NetworkBehaviour)typeof(Unity.Netcode.NetworkBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkVariableBase instance_of_this_method = (Unity.Netcode.NetworkVariableBase)typeof(Unity.Netcode.NetworkVariableBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Initialize(@networkBehaviour);

            return __ret;
        }

        static StackObject* OnInitialize_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkVariableBase instance_of_this_method = (Unity.Netcode.NetworkVariableBase)typeof(Unity.Netcode.NetworkVariableBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnInitialize();

            return __ret;
        }

        static StackObject* SetUpdateTraits_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkVariableUpdateTraits @traits = (Unity.Netcode.NetworkVariableUpdateTraits)typeof(Unity.Netcode.NetworkVariableUpdateTraits).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkVariableBase instance_of_this_method = (Unity.Netcode.NetworkVariableBase)typeof(Unity.Netcode.NetworkVariableBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetUpdateTraits(@traits);

            return __ret;
        }

        static StackObject* ExceedsDirtinessThreshold_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkVariableBase instance_of_this_method = (Unity.Netcode.NetworkVariableBase)typeof(Unity.Netcode.NetworkVariableBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ExceedsDirtinessThreshold();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_Name_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkVariableBase instance_of_this_method = (Unity.Netcode.NetworkVariableBase)typeof(Unity.Netcode.NetworkVariableBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Name;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_WritePerm_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkVariableBase instance_of_this_method = (Unity.Netcode.NetworkVariableBase)typeof(Unity.Netcode.NetworkVariableBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.WritePerm;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetDirty_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @isDirty = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkVariableBase instance_of_this_method = (Unity.Netcode.NetworkVariableBase)typeof(Unity.Netcode.NetworkVariableBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetDirty(@isDirty);

            return __ret;
        }

        static StackObject* ResetDirty_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkVariableBase instance_of_this_method = (Unity.Netcode.NetworkVariableBase)typeof(Unity.Netcode.NetworkVariableBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ResetDirty();

            return __ret;
        }

        static StackObject* IsDirty_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkVariableBase instance_of_this_method = (Unity.Netcode.NetworkVariableBase)typeof(Unity.Netcode.NetworkVariableBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsDirty();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* CanClientRead_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @clientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkVariableBase instance_of_this_method = (Unity.Netcode.NetworkVariableBase)typeof(Unity.Netcode.NetworkVariableBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CanClientRead(@clientId);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* CanClientWrite_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @clientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkVariableBase instance_of_this_method = (Unity.Netcode.NetworkVariableBase)typeof(Unity.Netcode.NetworkVariableBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CanClientWrite(@clientId);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* WriteDelta_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.FastBufferWriter @writer = (Unity.Netcode.FastBufferWriter)typeof(Unity.Netcode.FastBufferWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkVariableBase instance_of_this_method = (Unity.Netcode.NetworkVariableBase)typeof(Unity.Netcode.NetworkVariableBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteDelta(@writer);

            return __ret;
        }

        static StackObject* WriteField_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.FastBufferWriter @writer = (Unity.Netcode.FastBufferWriter)typeof(Unity.Netcode.FastBufferWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkVariableBase instance_of_this_method = (Unity.Netcode.NetworkVariableBase)typeof(Unity.Netcode.NetworkVariableBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteField(@writer);

            return __ret;
        }

        static StackObject* ReadField_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.FastBufferReader @reader = (Unity.Netcode.FastBufferReader)typeof(Unity.Netcode.FastBufferReader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkVariableBase instance_of_this_method = (Unity.Netcode.NetworkVariableBase)typeof(Unity.Netcode.NetworkVariableBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ReadField(@reader);

            return __ret;
        }

        static StackObject* ReadDelta_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @keepDirtyDelta = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.FastBufferReader @reader = (Unity.Netcode.FastBufferReader)typeof(Unity.Netcode.FastBufferReader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Netcode.NetworkVariableBase instance_of_this_method = (Unity.Netcode.NetworkVariableBase)typeof(Unity.Netcode.NetworkVariableBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ReadDelta(@reader, @keepDirtyDelta);

            return __ret;
        }

        static StackObject* Dispose_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkVariableBase instance_of_this_method = (Unity.Netcode.NetworkVariableBase)typeof(Unity.Netcode.NetworkVariableBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Dispose();

            return __ret;
        }


        static object get_DefaultReadPerm_0(ref object o)
        {
            return Unity.Netcode.NetworkVariableBase.DefaultReadPerm;
        }

        static StackObject* CopyToStack_DefaultReadPerm_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.NetworkVariableBase.DefaultReadPerm;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_DefaultWritePerm_1(ref object o)
        {
            return Unity.Netcode.NetworkVariableBase.DefaultWritePerm;
        }

        static StackObject* CopyToStack_DefaultWritePerm_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.NetworkVariableBase.DefaultWritePerm;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ReadPerm_2(ref object o)
        {
            return ((Unity.Netcode.NetworkVariableBase)o).ReadPerm;
        }

        static StackObject* CopyToStack_ReadPerm_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkVariableBase)o).ReadPerm;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




    }
}

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
    unsafe class UnityEngine_InputSystem_Users_InputUserPairingOptions_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.InputSystem.Users.InputUserPairingOptions);

            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_None_0, null);
            field = type.GetField("ForcePlatformUserAccountSelection", flag);
            app.RegisterCLRFieldGetter(field, get_ForcePlatformUserAccountSelection_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_ForcePlatformUserAccountSelection_1, null);
            field = type.GetField("ForceNoPlatformUserAccountSelection", flag);
            app.RegisterCLRFieldGetter(field, get_ForceNoPlatformUserAccountSelection_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_ForceNoPlatformUserAccountSelection_2, null);
            field = type.GetField("UnpairCurrentDevicesFromUser", flag);
            app.RegisterCLRFieldGetter(field, get_UnpairCurrentDevicesFromUser_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_UnpairCurrentDevicesFromUser_3, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.InputSystem.Users.InputUserPairingOptions());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.InputSystem.Users.InputUserPairingOptions[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.InputSystem.Users.InputUserPairingOptions instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.InputSystem.Users.InputUserPairingOptions[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_None_0(ref object o)
        {
            return UnityEngine.InputSystem.Users.InputUserPairingOptions.None;
        }

        static StackObject* CopyToStack_None_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.Users.InputUserPairingOptions.None;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ForcePlatformUserAccountSelection_1(ref object o)
        {
            return UnityEngine.InputSystem.Users.InputUserPairingOptions.ForcePlatformUserAccountSelection;
        }

        static StackObject* CopyToStack_ForcePlatformUserAccountSelection_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.Users.InputUserPairingOptions.ForcePlatformUserAccountSelection;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ForceNoPlatformUserAccountSelection_2(ref object o)
        {
            return UnityEngine.InputSystem.Users.InputUserPairingOptions.ForceNoPlatformUserAccountSelection;
        }

        static StackObject* CopyToStack_ForceNoPlatformUserAccountSelection_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.Users.InputUserPairingOptions.ForceNoPlatformUserAccountSelection;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_UnpairCurrentDevicesFromUser_3(ref object o)
        {
            return UnityEngine.InputSystem.Users.InputUserPairingOptions.UnpairCurrentDevicesFromUser;
        }

        static StackObject* CopyToStack_UnpairCurrentDevicesFromUser_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.Users.InputUserPairingOptions.UnpairCurrentDevicesFromUser;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.InputSystem.Users.InputUserPairingOptions();
            ins = (UnityEngine.InputSystem.Users.InputUserPairingOptions)o;
            return ins;
        }


    }
}

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
    unsafe class UnityEngine_InputSystem_Users_InputUserChange_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.InputSystem.Users.InputUserChange);

            field = type.GetField("Added", flag);
            app.RegisterCLRFieldGetter(field, get_Added_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Added_0, null);
            field = type.GetField("Removed", flag);
            app.RegisterCLRFieldGetter(field, get_Removed_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Removed_1, null);
            field = type.GetField("DevicePaired", flag);
            app.RegisterCLRFieldGetter(field, get_DevicePaired_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_DevicePaired_2, null);
            field = type.GetField("DeviceUnpaired", flag);
            app.RegisterCLRFieldGetter(field, get_DeviceUnpaired_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_DeviceUnpaired_3, null);
            field = type.GetField("DeviceLost", flag);
            app.RegisterCLRFieldGetter(field, get_DeviceLost_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_DeviceLost_4, null);
            field = type.GetField("DeviceRegained", flag);
            app.RegisterCLRFieldGetter(field, get_DeviceRegained_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_DeviceRegained_5, null);
            field = type.GetField("AccountChanged", flag);
            app.RegisterCLRFieldGetter(field, get_AccountChanged_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_AccountChanged_6, null);
            field = type.GetField("AccountNameChanged", flag);
            app.RegisterCLRFieldGetter(field, get_AccountNameChanged_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_AccountNameChanged_7, null);
            field = type.GetField("AccountSelectionInProgress", flag);
            app.RegisterCLRFieldGetter(field, get_AccountSelectionInProgress_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_AccountSelectionInProgress_8, null);
            field = type.GetField("AccountSelectionCanceled", flag);
            app.RegisterCLRFieldGetter(field, get_AccountSelectionCanceled_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_AccountSelectionCanceled_9, null);
            field = type.GetField("AccountSelectionComplete", flag);
            app.RegisterCLRFieldGetter(field, get_AccountSelectionComplete_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_AccountSelectionComplete_10, null);
            field = type.GetField("ControlSchemeChanged", flag);
            app.RegisterCLRFieldGetter(field, get_ControlSchemeChanged_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_ControlSchemeChanged_11, null);
            field = type.GetField("ControlsChanged", flag);
            app.RegisterCLRFieldGetter(field, get_ControlsChanged_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_ControlsChanged_12, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.InputSystem.Users.InputUserChange());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.InputSystem.Users.InputUserChange[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.InputSystem.Users.InputUserChange instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.InputSystem.Users.InputUserChange[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Added_0(ref object o)
        {
            return UnityEngine.InputSystem.Users.InputUserChange.Added;
        }

        static StackObject* CopyToStack_Added_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.Users.InputUserChange.Added;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Removed_1(ref object o)
        {
            return UnityEngine.InputSystem.Users.InputUserChange.Removed;
        }

        static StackObject* CopyToStack_Removed_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.Users.InputUserChange.Removed;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_DevicePaired_2(ref object o)
        {
            return UnityEngine.InputSystem.Users.InputUserChange.DevicePaired;
        }

        static StackObject* CopyToStack_DevicePaired_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.Users.InputUserChange.DevicePaired;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_DeviceUnpaired_3(ref object o)
        {
            return UnityEngine.InputSystem.Users.InputUserChange.DeviceUnpaired;
        }

        static StackObject* CopyToStack_DeviceUnpaired_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.Users.InputUserChange.DeviceUnpaired;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_DeviceLost_4(ref object o)
        {
            return UnityEngine.InputSystem.Users.InputUserChange.DeviceLost;
        }

        static StackObject* CopyToStack_DeviceLost_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.Users.InputUserChange.DeviceLost;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_DeviceRegained_5(ref object o)
        {
            return UnityEngine.InputSystem.Users.InputUserChange.DeviceRegained;
        }

        static StackObject* CopyToStack_DeviceRegained_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.Users.InputUserChange.DeviceRegained;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_AccountChanged_6(ref object o)
        {
            return UnityEngine.InputSystem.Users.InputUserChange.AccountChanged;
        }

        static StackObject* CopyToStack_AccountChanged_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.Users.InputUserChange.AccountChanged;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_AccountNameChanged_7(ref object o)
        {
            return UnityEngine.InputSystem.Users.InputUserChange.AccountNameChanged;
        }

        static StackObject* CopyToStack_AccountNameChanged_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.Users.InputUserChange.AccountNameChanged;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_AccountSelectionInProgress_8(ref object o)
        {
            return UnityEngine.InputSystem.Users.InputUserChange.AccountSelectionInProgress;
        }

        static StackObject* CopyToStack_AccountSelectionInProgress_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.Users.InputUserChange.AccountSelectionInProgress;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_AccountSelectionCanceled_9(ref object o)
        {
            return UnityEngine.InputSystem.Users.InputUserChange.AccountSelectionCanceled;
        }

        static StackObject* CopyToStack_AccountSelectionCanceled_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.Users.InputUserChange.AccountSelectionCanceled;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_AccountSelectionComplete_10(ref object o)
        {
            return UnityEngine.InputSystem.Users.InputUserChange.AccountSelectionComplete;
        }

        static StackObject* CopyToStack_AccountSelectionComplete_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.Users.InputUserChange.AccountSelectionComplete;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ControlSchemeChanged_11(ref object o)
        {
            return UnityEngine.InputSystem.Users.InputUserChange.ControlSchemeChanged;
        }

        static StackObject* CopyToStack_ControlSchemeChanged_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.Users.InputUserChange.ControlSchemeChanged;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ControlsChanged_12(ref object o)
        {
            return UnityEngine.InputSystem.Users.InputUserChange.ControlsChanged;
        }

        static StackObject* CopyToStack_ControlsChanged_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.Users.InputUserChange.ControlsChanged;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.InputSystem.Users.InputUserChange();
            ins = (UnityEngine.InputSystem.Users.InputUserChange)o;
            return ins;
        }


    }
}

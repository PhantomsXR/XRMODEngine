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
    unsafe class CommonUsages_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.InputSystem.CommonUsages);

            field = type.GetField("Primary2DMotion", flag);
            app.RegisterCLRFieldGetter(field, get_Primary2DMotion_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Primary2DMotion_0, null);
            field = type.GetField("Secondary2DMotion", flag);
            app.RegisterCLRFieldGetter(field, get_Secondary2DMotion_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Secondary2DMotion_1, null);
            field = type.GetField("PrimaryAction", flag);
            app.RegisterCLRFieldGetter(field, get_PrimaryAction_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_PrimaryAction_2, null);
            field = type.GetField("SecondaryAction", flag);
            app.RegisterCLRFieldGetter(field, get_SecondaryAction_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_SecondaryAction_3, null);
            field = type.GetField("PrimaryTrigger", flag);
            app.RegisterCLRFieldGetter(field, get_PrimaryTrigger_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_PrimaryTrigger_4, null);
            field = type.GetField("SecondaryTrigger", flag);
            app.RegisterCLRFieldGetter(field, get_SecondaryTrigger_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_SecondaryTrigger_5, null);
            field = type.GetField("Modifier", flag);
            app.RegisterCLRFieldGetter(field, get_Modifier_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_Modifier_6, null);
            field = type.GetField("Position", flag);
            app.RegisterCLRFieldGetter(field, get_Position_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_Position_7, null);
            field = type.GetField("Orientation", flag);
            app.RegisterCLRFieldGetter(field, get_Orientation_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_Orientation_8, null);
            field = type.GetField("Hatswitch", flag);
            app.RegisterCLRFieldGetter(field, get_Hatswitch_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_Hatswitch_9, null);
            field = type.GetField("Back", flag);
            app.RegisterCLRFieldGetter(field, get_Back_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_Back_10, null);
            field = type.GetField("Forward", flag);
            app.RegisterCLRFieldGetter(field, get_Forward_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_Forward_11, null);
            field = type.GetField("Menu", flag);
            app.RegisterCLRFieldGetter(field, get_Menu_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_Menu_12, null);
            field = type.GetField("Submit", flag);
            app.RegisterCLRFieldGetter(field, get_Submit_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_Submit_13, null);
            field = type.GetField("Cancel", flag);
            app.RegisterCLRFieldGetter(field, get_Cancel_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_Cancel_14, null);
            field = type.GetField("Horizontal", flag);
            app.RegisterCLRFieldGetter(field, get_Horizontal_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_Horizontal_15, null);
            field = type.GetField("Vertical", flag);
            app.RegisterCLRFieldGetter(field, get_Vertical_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_Vertical_16, null);
            field = type.GetField("Twist", flag);
            app.RegisterCLRFieldGetter(field, get_Twist_17);
            app.RegisterCLRFieldBinding(field, CopyToStack_Twist_17, null);
            field = type.GetField("Pressure", flag);
            app.RegisterCLRFieldGetter(field, get_Pressure_18);
            app.RegisterCLRFieldBinding(field, CopyToStack_Pressure_18, null);
            field = type.GetField("ScrollHorizontal", flag);
            app.RegisterCLRFieldGetter(field, get_ScrollHorizontal_19);
            app.RegisterCLRFieldBinding(field, CopyToStack_ScrollHorizontal_19, null);
            field = type.GetField("ScrollVertical", flag);
            app.RegisterCLRFieldGetter(field, get_ScrollVertical_20);
            app.RegisterCLRFieldBinding(field, CopyToStack_ScrollVertical_20, null);
            field = type.GetField("Point", flag);
            app.RegisterCLRFieldGetter(field, get_Point_21);
            app.RegisterCLRFieldBinding(field, CopyToStack_Point_21, null);
            field = type.GetField("LowFreqMotor", flag);
            app.RegisterCLRFieldGetter(field, get_LowFreqMotor_22);
            app.RegisterCLRFieldBinding(field, CopyToStack_LowFreqMotor_22, null);
            field = type.GetField("HighFreqMotor", flag);
            app.RegisterCLRFieldGetter(field, get_HighFreqMotor_23);
            app.RegisterCLRFieldBinding(field, CopyToStack_HighFreqMotor_23, null);
            field = type.GetField("LeftHand", flag);
            app.RegisterCLRFieldGetter(field, get_LeftHand_24);
            app.RegisterCLRFieldBinding(field, CopyToStack_LeftHand_24, null);
            field = type.GetField("RightHand", flag);
            app.RegisterCLRFieldGetter(field, get_RightHand_25);
            app.RegisterCLRFieldBinding(field, CopyToStack_RightHand_25, null);
            field = type.GetField("BatteryStrength", flag);
            app.RegisterCLRFieldGetter(field, get_BatteryStrength_26);
            app.RegisterCLRFieldBinding(field, CopyToStack_BatteryStrength_26, null);




        }



        static object get_Primary2DMotion_0(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.Primary2DMotion;
        }

        static StackObject* CopyToStack_Primary2DMotion_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.Primary2DMotion;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Secondary2DMotion_1(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.Secondary2DMotion;
        }

        static StackObject* CopyToStack_Secondary2DMotion_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.Secondary2DMotion;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_PrimaryAction_2(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.PrimaryAction;
        }

        static StackObject* CopyToStack_PrimaryAction_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.PrimaryAction;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_SecondaryAction_3(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.SecondaryAction;
        }

        static StackObject* CopyToStack_SecondaryAction_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.SecondaryAction;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_PrimaryTrigger_4(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.PrimaryTrigger;
        }

        static StackObject* CopyToStack_PrimaryTrigger_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.PrimaryTrigger;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_SecondaryTrigger_5(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.SecondaryTrigger;
        }

        static StackObject* CopyToStack_SecondaryTrigger_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.SecondaryTrigger;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Modifier_6(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.Modifier;
        }

        static StackObject* CopyToStack_Modifier_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.Modifier;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Position_7(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.Position;
        }

        static StackObject* CopyToStack_Position_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.Position;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Orientation_8(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.Orientation;
        }

        static StackObject* CopyToStack_Orientation_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.Orientation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Hatswitch_9(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.Hatswitch;
        }

        static StackObject* CopyToStack_Hatswitch_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.Hatswitch;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Back_10(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.Back;
        }

        static StackObject* CopyToStack_Back_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.Back;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Forward_11(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.Forward;
        }

        static StackObject* CopyToStack_Forward_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.Forward;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Menu_12(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.Menu;
        }

        static StackObject* CopyToStack_Menu_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.Menu;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Submit_13(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.Submit;
        }

        static StackObject* CopyToStack_Submit_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.Submit;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Cancel_14(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.Cancel;
        }

        static StackObject* CopyToStack_Cancel_14(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.Cancel;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Horizontal_15(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.Horizontal;
        }

        static StackObject* CopyToStack_Horizontal_15(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.Horizontal;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Vertical_16(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.Vertical;
        }

        static StackObject* CopyToStack_Vertical_16(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.Vertical;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Twist_17(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.Twist;
        }

        static StackObject* CopyToStack_Twist_17(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.Twist;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Pressure_18(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.Pressure;
        }

        static StackObject* CopyToStack_Pressure_18(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.Pressure;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ScrollHorizontal_19(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.ScrollHorizontal;
        }

        static StackObject* CopyToStack_ScrollHorizontal_19(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.ScrollHorizontal;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ScrollVertical_20(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.ScrollVertical;
        }

        static StackObject* CopyToStack_ScrollVertical_20(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.ScrollVertical;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Point_21(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.Point;
        }

        static StackObject* CopyToStack_Point_21(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.Point;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_LowFreqMotor_22(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.LowFreqMotor;
        }

        static StackObject* CopyToStack_LowFreqMotor_22(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.LowFreqMotor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_HighFreqMotor_23(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.HighFreqMotor;
        }

        static StackObject* CopyToStack_HighFreqMotor_23(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.HighFreqMotor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_LeftHand_24(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.LeftHand;
        }

        static StackObject* CopyToStack_LeftHand_24(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.LeftHand;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_RightHand_25(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.RightHand;
        }

        static StackObject* CopyToStack_RightHand_25(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.RightHand;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_BatteryStrength_26(ref object o)
        {
            return UnityEngine.InputSystem.CommonUsages.BatteryStrength;
        }

        static StackObject* CopyToStack_BatteryStrength_26(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.CommonUsages.BatteryStrength;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




    }
}

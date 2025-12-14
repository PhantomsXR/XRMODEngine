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
    unsafe class TweenAction_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::TweenAction);

            field = type.GetField("MOVE_X", flag);
            app.RegisterCLRFieldGetter(field, get_MOVE_X_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_MOVE_X_0, null);
            field = type.GetField("MOVE_Y", flag);
            app.RegisterCLRFieldGetter(field, get_MOVE_Y_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_MOVE_Y_1, null);
            field = type.GetField("MOVE_Z", flag);
            app.RegisterCLRFieldGetter(field, get_MOVE_Z_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_MOVE_Z_2, null);
            field = type.GetField("MOVE_LOCAL_X", flag);
            app.RegisterCLRFieldGetter(field, get_MOVE_LOCAL_X_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_MOVE_LOCAL_X_3, null);
            field = type.GetField("MOVE_LOCAL_Y", flag);
            app.RegisterCLRFieldGetter(field, get_MOVE_LOCAL_Y_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_MOVE_LOCAL_Y_4, null);
            field = type.GetField("MOVE_LOCAL_Z", flag);
            app.RegisterCLRFieldGetter(field, get_MOVE_LOCAL_Z_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_MOVE_LOCAL_Z_5, null);
            field = type.GetField("MOVE_CURVED", flag);
            app.RegisterCLRFieldGetter(field, get_MOVE_CURVED_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_MOVE_CURVED_6, null);
            field = type.GetField("MOVE_CURVED_LOCAL", flag);
            app.RegisterCLRFieldGetter(field, get_MOVE_CURVED_LOCAL_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_MOVE_CURVED_LOCAL_7, null);
            field = type.GetField("MOVE_SPLINE", flag);
            app.RegisterCLRFieldGetter(field, get_MOVE_SPLINE_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_MOVE_SPLINE_8, null);
            field = type.GetField("MOVE_SPLINE_LOCAL", flag);
            app.RegisterCLRFieldGetter(field, get_MOVE_SPLINE_LOCAL_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_MOVE_SPLINE_LOCAL_9, null);
            field = type.GetField("SCALE_X", flag);
            app.RegisterCLRFieldGetter(field, get_SCALE_X_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_SCALE_X_10, null);
            field = type.GetField("SCALE_Y", flag);
            app.RegisterCLRFieldGetter(field, get_SCALE_Y_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_SCALE_Y_11, null);
            field = type.GetField("SCALE_Z", flag);
            app.RegisterCLRFieldGetter(field, get_SCALE_Z_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_SCALE_Z_12, null);
            field = type.GetField("ROTATE_X", flag);
            app.RegisterCLRFieldGetter(field, get_ROTATE_X_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_ROTATE_X_13, null);
            field = type.GetField("ROTATE_Y", flag);
            app.RegisterCLRFieldGetter(field, get_ROTATE_Y_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_ROTATE_Y_14, null);
            field = type.GetField("ROTATE_Z", flag);
            app.RegisterCLRFieldGetter(field, get_ROTATE_Z_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_ROTATE_Z_15, null);
            field = type.GetField("ROTATE_AROUND", flag);
            app.RegisterCLRFieldGetter(field, get_ROTATE_AROUND_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_ROTATE_AROUND_16, null);
            field = type.GetField("ROTATE_AROUND_LOCAL", flag);
            app.RegisterCLRFieldGetter(field, get_ROTATE_AROUND_LOCAL_17);
            app.RegisterCLRFieldBinding(field, CopyToStack_ROTATE_AROUND_LOCAL_17, null);
            field = type.GetField("CANVAS_ROTATEAROUND", flag);
            app.RegisterCLRFieldGetter(field, get_CANVAS_ROTATEAROUND_18);
            app.RegisterCLRFieldBinding(field, CopyToStack_CANVAS_ROTATEAROUND_18, null);
            field = type.GetField("CANVAS_ROTATEAROUND_LOCAL", flag);
            app.RegisterCLRFieldGetter(field, get_CANVAS_ROTATEAROUND_LOCAL_19);
            app.RegisterCLRFieldBinding(field, CopyToStack_CANVAS_ROTATEAROUND_LOCAL_19, null);
            field = type.GetField("CANVAS_PLAYSPRITE", flag);
            app.RegisterCLRFieldGetter(field, get_CANVAS_PLAYSPRITE_20);
            app.RegisterCLRFieldBinding(field, CopyToStack_CANVAS_PLAYSPRITE_20, null);
            field = type.GetField("ALPHA", flag);
            app.RegisterCLRFieldGetter(field, get_ALPHA_21);
            app.RegisterCLRFieldBinding(field, CopyToStack_ALPHA_21, null);
            field = type.GetField("TEXT_ALPHA", flag);
            app.RegisterCLRFieldGetter(field, get_TEXT_ALPHA_22);
            app.RegisterCLRFieldBinding(field, CopyToStack_TEXT_ALPHA_22, null);
            field = type.GetField("CANVAS_ALPHA", flag);
            app.RegisterCLRFieldGetter(field, get_CANVAS_ALPHA_23);
            app.RegisterCLRFieldBinding(field, CopyToStack_CANVAS_ALPHA_23, null);
            field = type.GetField("CANVASGROUP_ALPHA", flag);
            app.RegisterCLRFieldGetter(field, get_CANVASGROUP_ALPHA_24);
            app.RegisterCLRFieldBinding(field, CopyToStack_CANVASGROUP_ALPHA_24, null);
            field = type.GetField("ALPHA_VERTEX", flag);
            app.RegisterCLRFieldGetter(field, get_ALPHA_VERTEX_25);
            app.RegisterCLRFieldBinding(field, CopyToStack_ALPHA_VERTEX_25, null);
            field = type.GetField("COLOR", flag);
            app.RegisterCLRFieldGetter(field, get_COLOR_26);
            app.RegisterCLRFieldBinding(field, CopyToStack_COLOR_26, null);
            field = type.GetField("CALLBACK_COLOR", flag);
            app.RegisterCLRFieldGetter(field, get_CALLBACK_COLOR_27);
            app.RegisterCLRFieldBinding(field, CopyToStack_CALLBACK_COLOR_27, null);
            field = type.GetField("TEXT_COLOR", flag);
            app.RegisterCLRFieldGetter(field, get_TEXT_COLOR_28);
            app.RegisterCLRFieldBinding(field, CopyToStack_TEXT_COLOR_28, null);
            field = type.GetField("CANVAS_COLOR", flag);
            app.RegisterCLRFieldGetter(field, get_CANVAS_COLOR_29);
            app.RegisterCLRFieldBinding(field, CopyToStack_CANVAS_COLOR_29, null);
            field = type.GetField("CANVAS_MOVE_X", flag);
            app.RegisterCLRFieldGetter(field, get_CANVAS_MOVE_X_30);
            app.RegisterCLRFieldBinding(field, CopyToStack_CANVAS_MOVE_X_30, null);
            field = type.GetField("CANVAS_MOVE_Y", flag);
            app.RegisterCLRFieldGetter(field, get_CANVAS_MOVE_Y_31);
            app.RegisterCLRFieldBinding(field, CopyToStack_CANVAS_MOVE_Y_31, null);
            field = type.GetField("CANVAS_MOVE_Z", flag);
            app.RegisterCLRFieldGetter(field, get_CANVAS_MOVE_Z_32);
            app.RegisterCLRFieldBinding(field, CopyToStack_CANVAS_MOVE_Z_32, null);
            field = type.GetField("CALLBACK", flag);
            app.RegisterCLRFieldGetter(field, get_CALLBACK_33);
            app.RegisterCLRFieldBinding(field, CopyToStack_CALLBACK_33, null);
            field = type.GetField("MOVE", flag);
            app.RegisterCLRFieldGetter(field, get_MOVE_34);
            app.RegisterCLRFieldBinding(field, CopyToStack_MOVE_34, null);
            field = type.GetField("MOVE_LOCAL", flag);
            app.RegisterCLRFieldGetter(field, get_MOVE_LOCAL_35);
            app.RegisterCLRFieldBinding(field, CopyToStack_MOVE_LOCAL_35, null);
            field = type.GetField("MOVE_TO_TRANSFORM", flag);
            app.RegisterCLRFieldGetter(field, get_MOVE_TO_TRANSFORM_36);
            app.RegisterCLRFieldBinding(field, CopyToStack_MOVE_TO_TRANSFORM_36, null);
            field = type.GetField("ROTATE", flag);
            app.RegisterCLRFieldGetter(field, get_ROTATE_37);
            app.RegisterCLRFieldBinding(field, CopyToStack_ROTATE_37, null);
            field = type.GetField("ROTATE_LOCAL", flag);
            app.RegisterCLRFieldGetter(field, get_ROTATE_LOCAL_38);
            app.RegisterCLRFieldBinding(field, CopyToStack_ROTATE_LOCAL_38, null);
            field = type.GetField("SCALE", flag);
            app.RegisterCLRFieldGetter(field, get_SCALE_39);
            app.RegisterCLRFieldBinding(field, CopyToStack_SCALE_39, null);
            field = type.GetField("VALUE3", flag);
            app.RegisterCLRFieldGetter(field, get_VALUE3_40);
            app.RegisterCLRFieldBinding(field, CopyToStack_VALUE3_40, null);
            field = type.GetField("GUI_MOVE", flag);
            app.RegisterCLRFieldGetter(field, get_GUI_MOVE_41);
            app.RegisterCLRFieldBinding(field, CopyToStack_GUI_MOVE_41, null);
            field = type.GetField("GUI_MOVE_MARGIN", flag);
            app.RegisterCLRFieldGetter(field, get_GUI_MOVE_MARGIN_42);
            app.RegisterCLRFieldBinding(field, CopyToStack_GUI_MOVE_MARGIN_42, null);
            field = type.GetField("GUI_SCALE", flag);
            app.RegisterCLRFieldGetter(field, get_GUI_SCALE_43);
            app.RegisterCLRFieldBinding(field, CopyToStack_GUI_SCALE_43, null);
            field = type.GetField("GUI_ALPHA", flag);
            app.RegisterCLRFieldGetter(field, get_GUI_ALPHA_44);
            app.RegisterCLRFieldBinding(field, CopyToStack_GUI_ALPHA_44, null);
            field = type.GetField("GUI_ROTATE", flag);
            app.RegisterCLRFieldGetter(field, get_GUI_ROTATE_45);
            app.RegisterCLRFieldBinding(field, CopyToStack_GUI_ROTATE_45, null);
            field = type.GetField("DELAYED_SOUND", flag);
            app.RegisterCLRFieldGetter(field, get_DELAYED_SOUND_46);
            app.RegisterCLRFieldBinding(field, CopyToStack_DELAYED_SOUND_46, null);
            field = type.GetField("CANVAS_MOVE", flag);
            app.RegisterCLRFieldGetter(field, get_CANVAS_MOVE_47);
            app.RegisterCLRFieldBinding(field, CopyToStack_CANVAS_MOVE_47, null);
            field = type.GetField("CANVAS_SCALE", flag);
            app.RegisterCLRFieldGetter(field, get_CANVAS_SCALE_48);
            app.RegisterCLRFieldBinding(field, CopyToStack_CANVAS_SCALE_48, null);
            field = type.GetField("CANVAS_SIZEDELTA", flag);
            app.RegisterCLRFieldGetter(field, get_CANVAS_SIZEDELTA_49);
            app.RegisterCLRFieldBinding(field, CopyToStack_CANVAS_SIZEDELTA_49, null);
            field = type.GetField("FOLLOW", flag);
            app.RegisterCLRFieldGetter(field, get_FOLLOW_50);
            app.RegisterCLRFieldBinding(field, CopyToStack_FOLLOW_50, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new global::TweenAction());
            app.RegisterCLRCreateArrayInstance(type, s => new global::TweenAction[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref global::TweenAction instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as global::TweenAction[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_MOVE_X_0(ref object o)
        {
            return global::TweenAction.MOVE_X;
        }

        static StackObject* CopyToStack_MOVE_X_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.MOVE_X;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_MOVE_Y_1(ref object o)
        {
            return global::TweenAction.MOVE_Y;
        }

        static StackObject* CopyToStack_MOVE_Y_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.MOVE_Y;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_MOVE_Z_2(ref object o)
        {
            return global::TweenAction.MOVE_Z;
        }

        static StackObject* CopyToStack_MOVE_Z_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.MOVE_Z;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_MOVE_LOCAL_X_3(ref object o)
        {
            return global::TweenAction.MOVE_LOCAL_X;
        }

        static StackObject* CopyToStack_MOVE_LOCAL_X_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.MOVE_LOCAL_X;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_MOVE_LOCAL_Y_4(ref object o)
        {
            return global::TweenAction.MOVE_LOCAL_Y;
        }

        static StackObject* CopyToStack_MOVE_LOCAL_Y_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.MOVE_LOCAL_Y;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_MOVE_LOCAL_Z_5(ref object o)
        {
            return global::TweenAction.MOVE_LOCAL_Z;
        }

        static StackObject* CopyToStack_MOVE_LOCAL_Z_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.MOVE_LOCAL_Z;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_MOVE_CURVED_6(ref object o)
        {
            return global::TweenAction.MOVE_CURVED;
        }

        static StackObject* CopyToStack_MOVE_CURVED_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.MOVE_CURVED;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_MOVE_CURVED_LOCAL_7(ref object o)
        {
            return global::TweenAction.MOVE_CURVED_LOCAL;
        }

        static StackObject* CopyToStack_MOVE_CURVED_LOCAL_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.MOVE_CURVED_LOCAL;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_MOVE_SPLINE_8(ref object o)
        {
            return global::TweenAction.MOVE_SPLINE;
        }

        static StackObject* CopyToStack_MOVE_SPLINE_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.MOVE_SPLINE;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_MOVE_SPLINE_LOCAL_9(ref object o)
        {
            return global::TweenAction.MOVE_SPLINE_LOCAL;
        }

        static StackObject* CopyToStack_MOVE_SPLINE_LOCAL_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.MOVE_SPLINE_LOCAL;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_SCALE_X_10(ref object o)
        {
            return global::TweenAction.SCALE_X;
        }

        static StackObject* CopyToStack_SCALE_X_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.SCALE_X;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_SCALE_Y_11(ref object o)
        {
            return global::TweenAction.SCALE_Y;
        }

        static StackObject* CopyToStack_SCALE_Y_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.SCALE_Y;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_SCALE_Z_12(ref object o)
        {
            return global::TweenAction.SCALE_Z;
        }

        static StackObject* CopyToStack_SCALE_Z_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.SCALE_Z;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ROTATE_X_13(ref object o)
        {
            return global::TweenAction.ROTATE_X;
        }

        static StackObject* CopyToStack_ROTATE_X_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.ROTATE_X;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ROTATE_Y_14(ref object o)
        {
            return global::TweenAction.ROTATE_Y;
        }

        static StackObject* CopyToStack_ROTATE_Y_14(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.ROTATE_Y;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ROTATE_Z_15(ref object o)
        {
            return global::TweenAction.ROTATE_Z;
        }

        static StackObject* CopyToStack_ROTATE_Z_15(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.ROTATE_Z;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ROTATE_AROUND_16(ref object o)
        {
            return global::TweenAction.ROTATE_AROUND;
        }

        static StackObject* CopyToStack_ROTATE_AROUND_16(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.ROTATE_AROUND;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ROTATE_AROUND_LOCAL_17(ref object o)
        {
            return global::TweenAction.ROTATE_AROUND_LOCAL;
        }

        static StackObject* CopyToStack_ROTATE_AROUND_LOCAL_17(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.ROTATE_AROUND_LOCAL;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_CANVAS_ROTATEAROUND_18(ref object o)
        {
            return global::TweenAction.CANVAS_ROTATEAROUND;
        }

        static StackObject* CopyToStack_CANVAS_ROTATEAROUND_18(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.CANVAS_ROTATEAROUND;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_CANVAS_ROTATEAROUND_LOCAL_19(ref object o)
        {
            return global::TweenAction.CANVAS_ROTATEAROUND_LOCAL;
        }

        static StackObject* CopyToStack_CANVAS_ROTATEAROUND_LOCAL_19(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.CANVAS_ROTATEAROUND_LOCAL;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_CANVAS_PLAYSPRITE_20(ref object o)
        {
            return global::TweenAction.CANVAS_PLAYSPRITE;
        }

        static StackObject* CopyToStack_CANVAS_PLAYSPRITE_20(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.CANVAS_PLAYSPRITE;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ALPHA_21(ref object o)
        {
            return global::TweenAction.ALPHA;
        }

        static StackObject* CopyToStack_ALPHA_21(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.ALPHA;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_TEXT_ALPHA_22(ref object o)
        {
            return global::TweenAction.TEXT_ALPHA;
        }

        static StackObject* CopyToStack_TEXT_ALPHA_22(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.TEXT_ALPHA;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_CANVAS_ALPHA_23(ref object o)
        {
            return global::TweenAction.CANVAS_ALPHA;
        }

        static StackObject* CopyToStack_CANVAS_ALPHA_23(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.CANVAS_ALPHA;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_CANVASGROUP_ALPHA_24(ref object o)
        {
            return global::TweenAction.CANVASGROUP_ALPHA;
        }

        static StackObject* CopyToStack_CANVASGROUP_ALPHA_24(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.CANVASGROUP_ALPHA;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ALPHA_VERTEX_25(ref object o)
        {
            return global::TweenAction.ALPHA_VERTEX;
        }

        static StackObject* CopyToStack_ALPHA_VERTEX_25(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.ALPHA_VERTEX;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_COLOR_26(ref object o)
        {
            return global::TweenAction.COLOR;
        }

        static StackObject* CopyToStack_COLOR_26(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.COLOR;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_CALLBACK_COLOR_27(ref object o)
        {
            return global::TweenAction.CALLBACK_COLOR;
        }

        static StackObject* CopyToStack_CALLBACK_COLOR_27(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.CALLBACK_COLOR;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_TEXT_COLOR_28(ref object o)
        {
            return global::TweenAction.TEXT_COLOR;
        }

        static StackObject* CopyToStack_TEXT_COLOR_28(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.TEXT_COLOR;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_CANVAS_COLOR_29(ref object o)
        {
            return global::TweenAction.CANVAS_COLOR;
        }

        static StackObject* CopyToStack_CANVAS_COLOR_29(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.CANVAS_COLOR;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_CANVAS_MOVE_X_30(ref object o)
        {
            return global::TweenAction.CANVAS_MOVE_X;
        }

        static StackObject* CopyToStack_CANVAS_MOVE_X_30(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.CANVAS_MOVE_X;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_CANVAS_MOVE_Y_31(ref object o)
        {
            return global::TweenAction.CANVAS_MOVE_Y;
        }

        static StackObject* CopyToStack_CANVAS_MOVE_Y_31(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.CANVAS_MOVE_Y;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_CANVAS_MOVE_Z_32(ref object o)
        {
            return global::TweenAction.CANVAS_MOVE_Z;
        }

        static StackObject* CopyToStack_CANVAS_MOVE_Z_32(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.CANVAS_MOVE_Z;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_CALLBACK_33(ref object o)
        {
            return global::TweenAction.CALLBACK;
        }

        static StackObject* CopyToStack_CALLBACK_33(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.CALLBACK;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_MOVE_34(ref object o)
        {
            return global::TweenAction.MOVE;
        }

        static StackObject* CopyToStack_MOVE_34(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.MOVE;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_MOVE_LOCAL_35(ref object o)
        {
            return global::TweenAction.MOVE_LOCAL;
        }

        static StackObject* CopyToStack_MOVE_LOCAL_35(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.MOVE_LOCAL;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_MOVE_TO_TRANSFORM_36(ref object o)
        {
            return global::TweenAction.MOVE_TO_TRANSFORM;
        }

        static StackObject* CopyToStack_MOVE_TO_TRANSFORM_36(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.MOVE_TO_TRANSFORM;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ROTATE_37(ref object o)
        {
            return global::TweenAction.ROTATE;
        }

        static StackObject* CopyToStack_ROTATE_37(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.ROTATE;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ROTATE_LOCAL_38(ref object o)
        {
            return global::TweenAction.ROTATE_LOCAL;
        }

        static StackObject* CopyToStack_ROTATE_LOCAL_38(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.ROTATE_LOCAL;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_SCALE_39(ref object o)
        {
            return global::TweenAction.SCALE;
        }

        static StackObject* CopyToStack_SCALE_39(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.SCALE;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_VALUE3_40(ref object o)
        {
            return global::TweenAction.VALUE3;
        }

        static StackObject* CopyToStack_VALUE3_40(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.VALUE3;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_GUI_MOVE_41(ref object o)
        {
            return global::TweenAction.GUI_MOVE;
        }

        static StackObject* CopyToStack_GUI_MOVE_41(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.GUI_MOVE;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_GUI_MOVE_MARGIN_42(ref object o)
        {
            return global::TweenAction.GUI_MOVE_MARGIN;
        }

        static StackObject* CopyToStack_GUI_MOVE_MARGIN_42(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.GUI_MOVE_MARGIN;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_GUI_SCALE_43(ref object o)
        {
            return global::TweenAction.GUI_SCALE;
        }

        static StackObject* CopyToStack_GUI_SCALE_43(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.GUI_SCALE;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_GUI_ALPHA_44(ref object o)
        {
            return global::TweenAction.GUI_ALPHA;
        }

        static StackObject* CopyToStack_GUI_ALPHA_44(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.GUI_ALPHA;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_GUI_ROTATE_45(ref object o)
        {
            return global::TweenAction.GUI_ROTATE;
        }

        static StackObject* CopyToStack_GUI_ROTATE_45(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.GUI_ROTATE;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_DELAYED_SOUND_46(ref object o)
        {
            return global::TweenAction.DELAYED_SOUND;
        }

        static StackObject* CopyToStack_DELAYED_SOUND_46(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.DELAYED_SOUND;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_CANVAS_MOVE_47(ref object o)
        {
            return global::TweenAction.CANVAS_MOVE;
        }

        static StackObject* CopyToStack_CANVAS_MOVE_47(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.CANVAS_MOVE;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_CANVAS_SCALE_48(ref object o)
        {
            return global::TweenAction.CANVAS_SCALE;
        }

        static StackObject* CopyToStack_CANVAS_SCALE_48(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.CANVAS_SCALE;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_CANVAS_SIZEDELTA_49(ref object o)
        {
            return global::TweenAction.CANVAS_SIZEDELTA;
        }

        static StackObject* CopyToStack_CANVAS_SIZEDELTA_49(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.CANVAS_SIZEDELTA;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_FOLLOW_50(ref object o)
        {
            return global::TweenAction.FOLLOW;
        }

        static StackObject* CopyToStack_FOLLOW_50(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::TweenAction.FOLLOW;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new global::TweenAction();
            ins = (global::TweenAction)o;
            return ins;
        }


    }
}

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
    unsafe class LTRect_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::LTRect);
            args = new Type[]{};
            method = type.GetMethod("get_hasInitiliazed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hasInitiliazed_0);
            args = new Type[]{};
            method = type.GetMethod("get_id", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_id_1);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("setId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, setId_2);
            args = new Type[]{};
            method = type.GetMethod("reset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, reset_3);
            args = new Type[]{};
            method = type.GetMethod("resetForRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, resetForRotation_4);
            args = new Type[]{};
            method = type.GetMethod("get_x", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_x_5);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_x", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_x_6);
            args = new Type[]{};
            method = type.GetMethod("get_y", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_y_7);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_y", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_y_8);
            args = new Type[]{};
            method = type.GetMethod("get_width", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_width_9);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_width", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_width_10);
            args = new Type[]{};
            method = type.GetMethod("get_height", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_height_11);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_height", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_height_12);
            args = new Type[]{};
            method = type.GetMethod("get_rect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rect_13);
            args = new Type[]{typeof(UnityEngine.Rect)};
            method = type.GetMethod("set_rect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_rect_14);
            args = new Type[]{typeof(UnityEngine.GUIStyle)};
            method = type.GetMethod("setStyle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, setStyle_15);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("setFontScaleToFit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, setFontScaleToFit_16);
            args = new Type[]{typeof(UnityEngine.Color)};
            method = type.GetMethod("setColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, setColor_17);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("setAlpha", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, setAlpha_18);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("setLabel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, setLabel_19);
            args = new Type[]{typeof(System.Boolean), typeof(UnityEngine.Rect)};
            method = type.GetMethod("setUseSimpleScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, setUseSimpleScale_20);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("setUseSimpleScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, setUseSimpleScale_21);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("setSizeByHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, setSizeByHeight_22);
            args = new Type[]{};
            method = type.GetMethod("ToString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToString_23);

            field = type.GetField("_rect", flag);
            app.RegisterCLRFieldGetter(field, get__rect_0);
            app.RegisterCLRFieldSetter(field, set__rect_0);
            app.RegisterCLRFieldBinding(field, CopyToStack__rect_0, AssignFromStack__rect_0);
            field = type.GetField("alpha", flag);
            app.RegisterCLRFieldGetter(field, get_alpha_1);
            app.RegisterCLRFieldSetter(field, set_alpha_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_alpha_1, AssignFromStack_alpha_1);
            field = type.GetField("rotation", flag);
            app.RegisterCLRFieldGetter(field, get_rotation_2);
            app.RegisterCLRFieldSetter(field, set_rotation_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_rotation_2, AssignFromStack_rotation_2);
            field = type.GetField("pivot", flag);
            app.RegisterCLRFieldGetter(field, get_pivot_3);
            app.RegisterCLRFieldSetter(field, set_pivot_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_pivot_3, AssignFromStack_pivot_3);
            field = type.GetField("margin", flag);
            app.RegisterCLRFieldGetter(field, get_margin_4);
            app.RegisterCLRFieldSetter(field, set_margin_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_margin_4, AssignFromStack_margin_4);
            field = type.GetField("relativeRect", flag);
            app.RegisterCLRFieldGetter(field, get_relativeRect_5);
            app.RegisterCLRFieldSetter(field, set_relativeRect_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_relativeRect_5, AssignFromStack_relativeRect_5);
            field = type.GetField("rotateEnabled", flag);
            app.RegisterCLRFieldGetter(field, get_rotateEnabled_6);
            app.RegisterCLRFieldSetter(field, set_rotateEnabled_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_rotateEnabled_6, AssignFromStack_rotateEnabled_6);
            field = type.GetField("rotateFinished", flag);
            app.RegisterCLRFieldGetter(field, get_rotateFinished_7);
            app.RegisterCLRFieldSetter(field, set_rotateFinished_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_rotateFinished_7, AssignFromStack_rotateFinished_7);
            field = type.GetField("alphaEnabled", flag);
            app.RegisterCLRFieldGetter(field, get_alphaEnabled_8);
            app.RegisterCLRFieldSetter(field, set_alphaEnabled_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_alphaEnabled_8, AssignFromStack_alphaEnabled_8);
            field = type.GetField("labelStr", flag);
            app.RegisterCLRFieldGetter(field, get_labelStr_9);
            app.RegisterCLRFieldSetter(field, set_labelStr_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_labelStr_9, AssignFromStack_labelStr_9);
            field = type.GetField("type", flag);
            app.RegisterCLRFieldGetter(field, get_type_10);
            app.RegisterCLRFieldSetter(field, set_type_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_type_10, AssignFromStack_type_10);
            field = type.GetField("style", flag);
            app.RegisterCLRFieldGetter(field, get_style_11);
            app.RegisterCLRFieldSetter(field, set_style_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_style_11, AssignFromStack_style_11);
            field = type.GetField("useColor", flag);
            app.RegisterCLRFieldGetter(field, get_useColor_12);
            app.RegisterCLRFieldSetter(field, set_useColor_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_useColor_12, AssignFromStack_useColor_12);
            field = type.GetField("color", flag);
            app.RegisterCLRFieldGetter(field, get_color_13);
            app.RegisterCLRFieldSetter(field, set_color_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_color_13, AssignFromStack_color_13);
            field = type.GetField("fontScaleToFit", flag);
            app.RegisterCLRFieldGetter(field, get_fontScaleToFit_14);
            app.RegisterCLRFieldSetter(field, set_fontScaleToFit_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_fontScaleToFit_14, AssignFromStack_fontScaleToFit_14);
            field = type.GetField("useSimpleScale", flag);
            app.RegisterCLRFieldGetter(field, get_useSimpleScale_15);
            app.RegisterCLRFieldSetter(field, set_useSimpleScale_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_useSimpleScale_15, AssignFromStack_useSimpleScale_15);
            field = type.GetField("sizeByHeight", flag);
            app.RegisterCLRFieldGetter(field, get_sizeByHeight_16);
            app.RegisterCLRFieldSetter(field, set_sizeByHeight_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_sizeByHeight_16, AssignFromStack_sizeByHeight_16);
            field = type.GetField("texture", flag);
            app.RegisterCLRFieldGetter(field, get_texture_17);
            app.RegisterCLRFieldSetter(field, set_texture_17);
            app.RegisterCLRFieldBinding(field, CopyToStack_texture_17, AssignFromStack_texture_17);
            field = type.GetField("counter", flag);
            app.RegisterCLRFieldGetter(field, get_counter_18);
            app.RegisterCLRFieldSetter(field, set_counter_18);
            app.RegisterCLRFieldBinding(field, CopyToStack_counter_18, AssignFromStack_counter_18);
            field = type.GetField("colorTouched", flag);
            app.RegisterCLRFieldGetter(field, get_colorTouched_19);
            app.RegisterCLRFieldSetter(field, set_colorTouched_19);
            app.RegisterCLRFieldBinding(field, CopyToStack_colorTouched_19, AssignFromStack_colorTouched_19);


            app.RegisterCLRCreateDefaultInstance(type, () => new global::LTRect());
            app.RegisterCLRCreateArrayInstance(type, s => new global::LTRect[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{typeof(UnityEngine.Rect)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_2);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_3);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_4);

        }


        static StackObject* get_hasInitiliazed_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hasInitiliazed;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_id_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.id;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* setId_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @counter = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @id = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.setId(@id, @counter);

            return __ret;
        }

        static StackObject* reset_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.reset();

            return __ret;
        }

        static StackObject* resetForRotation_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.resetForRotation();

            return __ret;
        }

        static StackObject* get_x_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.x;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_x_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.x = value;

            return __ret;
        }

        static StackObject* get_y_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.y;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_y_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.y = value;

            return __ret;
        }

        static StackObject* get_width_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.width;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_width_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.width = value;

            return __ret;
        }

        static StackObject* get_height_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.height;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_height_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.height = value;

            return __ret;
        }

        static StackObject* get_rect_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rect;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_rect_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rect @value = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.rect = value;

            return __ret;
        }

        static StackObject* setStyle_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.setStyle(@style);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* setFontScaleToFit_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @fontScaleToFit = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.setFontScaleToFit(@fontScaleToFit);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* setColor_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @color = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.setColor(@color);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* setAlpha_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @alpha = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.setAlpha(@alpha);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* setLabel_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @str = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.setLabel(@str);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* setUseSimpleScale_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rect @relativeRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @useSimpleScale = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.setUseSimpleScale(@useSimpleScale, @relativeRect);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* setUseSimpleScale_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @useSimpleScale = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.setUseSimpleScale(@useSimpleScale);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* setSizeByHeight_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @sizeByHeight = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.setSizeByHeight(@sizeByHeight);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToString_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTRect instance_of_this_method = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ToString();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get__rect_0(ref object o)
        {
            return ((global::LTRect)o)._rect;
        }

        static StackObject* CopyToStack__rect_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTRect)o)._rect;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set__rect_0(ref object o, object v)
        {
            ((global::LTRect)o)._rect = (UnityEngine.Rect)v;
        }

        static StackObject* AssignFromStack__rect_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Rect @_rect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((global::LTRect)o)._rect = @_rect;
            return ptr_of_this_method;
        }

        static object get_alpha_1(ref object o)
        {
            return ((global::LTRect)o).alpha;
        }

        static StackObject* CopyToStack_alpha_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTRect)o).alpha;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_alpha_1(ref object o, object v)
        {
            ((global::LTRect)o).alpha = (System.Single)v;
        }

        static StackObject* AssignFromStack_alpha_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @alpha = *(float*)&ptr_of_this_method->Value;
            ((global::LTRect)o).alpha = @alpha;
            return ptr_of_this_method;
        }

        static object get_rotation_2(ref object o)
        {
            return ((global::LTRect)o).rotation;
        }

        static StackObject* CopyToStack_rotation_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTRect)o).rotation;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_rotation_2(ref object o, object v)
        {
            ((global::LTRect)o).rotation = (System.Single)v;
        }

        static StackObject* AssignFromStack_rotation_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @rotation = *(float*)&ptr_of_this_method->Value;
            ((global::LTRect)o).rotation = @rotation;
            return ptr_of_this_method;
        }

        static object get_pivot_3(ref object o)
        {
            return ((global::LTRect)o).pivot;
        }

        static StackObject* CopyToStack_pivot_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTRect)o).pivot;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_pivot_3(ref object o, object v)
        {
            ((global::LTRect)o).pivot = (UnityEngine.Vector2)v;
        }

        static StackObject* AssignFromStack_pivot_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector2 @pivot = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((global::LTRect)o).pivot = @pivot;
            return ptr_of_this_method;
        }

        static object get_margin_4(ref object o)
        {
            return ((global::LTRect)o).margin;
        }

        static StackObject* CopyToStack_margin_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTRect)o).margin;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_margin_4(ref object o, object v)
        {
            ((global::LTRect)o).margin = (UnityEngine.Vector2)v;
        }

        static StackObject* AssignFromStack_margin_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector2 @margin = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((global::LTRect)o).margin = @margin;
            return ptr_of_this_method;
        }

        static object get_relativeRect_5(ref object o)
        {
            return ((global::LTRect)o).relativeRect;
        }

        static StackObject* CopyToStack_relativeRect_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTRect)o).relativeRect;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_relativeRect_5(ref object o, object v)
        {
            ((global::LTRect)o).relativeRect = (UnityEngine.Rect)v;
        }

        static StackObject* AssignFromStack_relativeRect_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Rect @relativeRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((global::LTRect)o).relativeRect = @relativeRect;
            return ptr_of_this_method;
        }

        static object get_rotateEnabled_6(ref object o)
        {
            return ((global::LTRect)o).rotateEnabled;
        }

        static StackObject* CopyToStack_rotateEnabled_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTRect)o).rotateEnabled;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_rotateEnabled_6(ref object o, object v)
        {
            ((global::LTRect)o).rotateEnabled = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_rotateEnabled_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @rotateEnabled = ptr_of_this_method->Value == 1;
            ((global::LTRect)o).rotateEnabled = @rotateEnabled;
            return ptr_of_this_method;
        }

        static object get_rotateFinished_7(ref object o)
        {
            return ((global::LTRect)o).rotateFinished;
        }

        static StackObject* CopyToStack_rotateFinished_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTRect)o).rotateFinished;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_rotateFinished_7(ref object o, object v)
        {
            ((global::LTRect)o).rotateFinished = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_rotateFinished_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @rotateFinished = ptr_of_this_method->Value == 1;
            ((global::LTRect)o).rotateFinished = @rotateFinished;
            return ptr_of_this_method;
        }

        static object get_alphaEnabled_8(ref object o)
        {
            return ((global::LTRect)o).alphaEnabled;
        }

        static StackObject* CopyToStack_alphaEnabled_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTRect)o).alphaEnabled;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_alphaEnabled_8(ref object o, object v)
        {
            ((global::LTRect)o).alphaEnabled = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_alphaEnabled_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @alphaEnabled = ptr_of_this_method->Value == 1;
            ((global::LTRect)o).alphaEnabled = @alphaEnabled;
            return ptr_of_this_method;
        }

        static object get_labelStr_9(ref object o)
        {
            return ((global::LTRect)o).labelStr;
        }

        static StackObject* CopyToStack_labelStr_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTRect)o).labelStr;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_labelStr_9(ref object o, object v)
        {
            ((global::LTRect)o).labelStr = (System.String)v;
        }

        static StackObject* AssignFromStack_labelStr_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @labelStr = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::LTRect)o).labelStr = @labelStr;
            return ptr_of_this_method;
        }

        static object get_type_10(ref object o)
        {
            return ((global::LTRect)o).type;
        }

        static StackObject* CopyToStack_type_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTRect)o).type;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_type_10(ref object o, object v)
        {
            ((global::LTRect)o).type = (global::LTGUI.Element_Type)v;
        }

        static StackObject* AssignFromStack_type_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            global::LTGUI.Element_Type @type = (global::LTGUI.Element_Type)typeof(global::LTGUI.Element_Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((global::LTRect)o).type = @type;
            return ptr_of_this_method;
        }

        static object get_style_11(ref object o)
        {
            return ((global::LTRect)o).style;
        }

        static StackObject* CopyToStack_style_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTRect)o).style;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_style_11(ref object o, object v)
        {
            ((global::LTRect)o).style = (UnityEngine.GUIStyle)v;
        }

        static StackObject* AssignFromStack_style_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GUIStyle @style = (UnityEngine.GUIStyle)typeof(UnityEngine.GUIStyle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::LTRect)o).style = @style;
            return ptr_of_this_method;
        }

        static object get_useColor_12(ref object o)
        {
            return ((global::LTRect)o).useColor;
        }

        static StackObject* CopyToStack_useColor_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTRect)o).useColor;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_useColor_12(ref object o, object v)
        {
            ((global::LTRect)o).useColor = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_useColor_12(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @useColor = ptr_of_this_method->Value == 1;
            ((global::LTRect)o).useColor = @useColor;
            return ptr_of_this_method;
        }

        static object get_color_13(ref object o)
        {
            return ((global::LTRect)o).color;
        }

        static StackObject* CopyToStack_color_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTRect)o).color;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_color_13(ref object o, object v)
        {
            ((global::LTRect)o).color = (UnityEngine.Color)v;
        }

        static StackObject* AssignFromStack_color_13(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Color @color = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((global::LTRect)o).color = @color;
            return ptr_of_this_method;
        }

        static object get_fontScaleToFit_14(ref object o)
        {
            return ((global::LTRect)o).fontScaleToFit;
        }

        static StackObject* CopyToStack_fontScaleToFit_14(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTRect)o).fontScaleToFit;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_fontScaleToFit_14(ref object o, object v)
        {
            ((global::LTRect)o).fontScaleToFit = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_fontScaleToFit_14(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @fontScaleToFit = ptr_of_this_method->Value == 1;
            ((global::LTRect)o).fontScaleToFit = @fontScaleToFit;
            return ptr_of_this_method;
        }

        static object get_useSimpleScale_15(ref object o)
        {
            return ((global::LTRect)o).useSimpleScale;
        }

        static StackObject* CopyToStack_useSimpleScale_15(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTRect)o).useSimpleScale;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_useSimpleScale_15(ref object o, object v)
        {
            ((global::LTRect)o).useSimpleScale = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_useSimpleScale_15(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @useSimpleScale = ptr_of_this_method->Value == 1;
            ((global::LTRect)o).useSimpleScale = @useSimpleScale;
            return ptr_of_this_method;
        }

        static object get_sizeByHeight_16(ref object o)
        {
            return ((global::LTRect)o).sizeByHeight;
        }

        static StackObject* CopyToStack_sizeByHeight_16(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTRect)o).sizeByHeight;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_sizeByHeight_16(ref object o, object v)
        {
            ((global::LTRect)o).sizeByHeight = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_sizeByHeight_16(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @sizeByHeight = ptr_of_this_method->Value == 1;
            ((global::LTRect)o).sizeByHeight = @sizeByHeight;
            return ptr_of_this_method;
        }

        static object get_texture_17(ref object o)
        {
            return ((global::LTRect)o).texture;
        }

        static StackObject* CopyToStack_texture_17(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTRect)o).texture;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_texture_17(ref object o, object v)
        {
            ((global::LTRect)o).texture = (UnityEngine.Texture)v;
        }

        static StackObject* AssignFromStack_texture_17(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Texture @texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::LTRect)o).texture = @texture;
            return ptr_of_this_method;
        }

        static object get_counter_18(ref object o)
        {
            return ((global::LTRect)o).counter;
        }

        static StackObject* CopyToStack_counter_18(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTRect)o).counter;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_counter_18(ref object o, object v)
        {
            ((global::LTRect)o).counter = (System.Int32)v;
        }

        static StackObject* AssignFromStack_counter_18(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @counter = ptr_of_this_method->Value;
            ((global::LTRect)o).counter = @counter;
            return ptr_of_this_method;
        }

        static object get_colorTouched_19(ref object o)
        {
            return global::LTRect.colorTouched;
        }

        static StackObject* CopyToStack_colorTouched_19(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LTRect.colorTouched;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_colorTouched_19(ref object o, object v)
        {
            global::LTRect.colorTouched = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_colorTouched_19(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @colorTouched = ptr_of_this_method->Value == 1;
            global::LTRect.colorTouched = @colorTouched;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new global::LTRect();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rect @rect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new global::LTRect(@rect);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @height = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @width = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @y = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = new global::LTRect(@x, @y, @width, @height);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @alpha = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @height = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @width = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @y = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = new global::LTRect(@x, @y, @width, @height, @alpha);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @rotation = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @alpha = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @height = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @width = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @y = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Single @x = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = new global::LTRect(@x, @y, @width, @height, @alpha, @rotation);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

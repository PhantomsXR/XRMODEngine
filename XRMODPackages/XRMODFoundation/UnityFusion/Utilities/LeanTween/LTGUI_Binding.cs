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
    unsafe class LTGUI_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::LTGUI);
            args = new Type[]{};
            method = type.GetMethod("init", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, init_0);
            args = new Type[]{};
            method = type.GetMethod("initRectCheck", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, initRectCheck_1);
            args = new Type[]{};
            method = type.GetMethod("reset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, reset_2);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("update", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, update_3);
            args = new Type[]{typeof(UnityEngine.Rect)};
            method = type.GetMethod("checkOnScreen", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, checkOnScreen_4);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("destroy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, destroy_5);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("destroyAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, destroyAll_6);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(System.String), typeof(System.Int32)};
            method = type.GetMethod("label", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, label_7);
            args = new Type[]{typeof(global::LTRect), typeof(System.String), typeof(System.Int32)};
            method = type.GetMethod("label", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, label_8);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(System.Int32)};
            method = type.GetMethod("texture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, texture_9);
            args = new Type[]{typeof(global::LTRect), typeof(UnityEngine.Texture), typeof(System.Int32)};
            method = type.GetMethod("texture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, texture_10);
            args = new Type[]{typeof(global::LTRect), typeof(System.Int32)};
            method = type.GetMethod("element", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, element_11);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(System.Int32)};
            method = type.GetMethod("hasNoOverlap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, hasNoOverlap_12);
            args = new Type[]{typeof(UnityEngine.Rect)};
            method = type.GetMethod("pressedWithinRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, pressedWithinRect_13);
            args = new Type[]{typeof(UnityEngine.Vector2), typeof(UnityEngine.Rect)};
            method = type.GetMethod("checkWithinRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, checkWithinRect_14);
            args = new Type[]{};
            method = type.GetMethod("firstTouch", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, firstTouch_15);

            field = type.GetField("RECT_LEVELS", flag);
            app.RegisterCLRFieldGetter(field, get_RECT_LEVELS_0);
            app.RegisterCLRFieldSetter(field, set_RECT_LEVELS_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_RECT_LEVELS_0, AssignFromStack_RECT_LEVELS_0);
            field = type.GetField("RECTS_PER_LEVEL", flag);
            app.RegisterCLRFieldGetter(field, get_RECTS_PER_LEVEL_1);
            app.RegisterCLRFieldSetter(field, set_RECTS_PER_LEVEL_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_RECTS_PER_LEVEL_1, AssignFromStack_RECTS_PER_LEVEL_1);
            field = type.GetField("BUTTONS_MAX", flag);
            app.RegisterCLRFieldGetter(field, get_BUTTONS_MAX_2);
            app.RegisterCLRFieldSetter(field, set_BUTTONS_MAX_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_BUTTONS_MAX_2, AssignFromStack_BUTTONS_MAX_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new global::LTGUI());
            app.RegisterCLRCreateArrayInstance(type, s => new global::LTGUI[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* init_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            global::LTGUI.init();

            return __ret;
        }

        static StackObject* initRectCheck_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            global::LTGUI.initRectCheck();

            return __ret;
        }

        static StackObject* reset_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            global::LTGUI.reset();

            return __ret;
        }

        static StackObject* update_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @updateLevel = ptr_of_this_method->Value;


            global::LTGUI.update(@updateLevel);

            return __ret;
        }

        static StackObject* checkOnScreen_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rect @rect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = global::LTGUI.checkOnScreen(@rect);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* destroy_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @id = ptr_of_this_method->Value;


            global::LTGUI.destroy(@id);

            return __ret;
        }

        static StackObject* destroyAll_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @depth = ptr_of_this_method->Value;


            global::LTGUI.destroyAll(@depth);

            return __ret;
        }

        static StackObject* label_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @depth = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @label = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rect @rect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = global::LTGUI.label(@rect, @label, @depth);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* label_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @depth = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @label = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            global::LTRect @rect = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = global::LTGUI.label(@rect, @label, @depth);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* texture_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @depth = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture @texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rect @rect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = global::LTGUI.texture(@rect, @texture, @depth);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* texture_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @depth = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture @texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            global::LTRect @rect = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = global::LTGUI.texture(@rect, @texture, @depth);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* element_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @depth = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTRect @rect = (global::LTRect)typeof(global::LTRect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = global::LTGUI.element(@rect, @depth);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* hasNoOverlap_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @depth = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rect @rect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = global::LTGUI.hasNoOverlap(@rect, @depth);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* pressedWithinRect_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rect @rect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = global::LTGUI.pressedWithinRect(@rect);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* checkWithinRect_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rect @rect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @vec2 = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = global::LTGUI.checkWithinRect(@vec2, @rect);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* firstTouch_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = global::LTGUI.firstTouch();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_RECT_LEVELS_0(ref object o)
        {
            return global::LTGUI.RECT_LEVELS;
        }

        static StackObject* CopyToStack_RECT_LEVELS_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LTGUI.RECT_LEVELS;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_RECT_LEVELS_0(ref object o, object v)
        {
            global::LTGUI.RECT_LEVELS = (System.Int32)v;
        }

        static StackObject* AssignFromStack_RECT_LEVELS_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @RECT_LEVELS = ptr_of_this_method->Value;
            global::LTGUI.RECT_LEVELS = @RECT_LEVELS;
            return ptr_of_this_method;
        }

        static object get_RECTS_PER_LEVEL_1(ref object o)
        {
            return global::LTGUI.RECTS_PER_LEVEL;
        }

        static StackObject* CopyToStack_RECTS_PER_LEVEL_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LTGUI.RECTS_PER_LEVEL;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_RECTS_PER_LEVEL_1(ref object o, object v)
        {
            global::LTGUI.RECTS_PER_LEVEL = (System.Int32)v;
        }

        static StackObject* AssignFromStack_RECTS_PER_LEVEL_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @RECTS_PER_LEVEL = ptr_of_this_method->Value;
            global::LTGUI.RECTS_PER_LEVEL = @RECTS_PER_LEVEL;
            return ptr_of_this_method;
        }

        static object get_BUTTONS_MAX_2(ref object o)
        {
            return global::LTGUI.BUTTONS_MAX;
        }

        static StackObject* CopyToStack_BUTTONS_MAX_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LTGUI.BUTTONS_MAX;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_BUTTONS_MAX_2(ref object o, object v)
        {
            global::LTGUI.BUTTONS_MAX = (System.Int32)v;
        }

        static StackObject* AssignFromStack_BUTTONS_MAX_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @BUTTONS_MAX = ptr_of_this_method->Value;
            global::LTGUI.BUTTONS_MAX = @BUTTONS_MAX;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new global::LTGUI();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

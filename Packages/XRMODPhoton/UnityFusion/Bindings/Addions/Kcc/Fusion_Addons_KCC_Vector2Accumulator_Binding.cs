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
    unsafe class Fusion_Addons_KCC_Vector2Accumulator_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.KCC.Vector2Accumulator);
            args = new Type[]{};
            method = type.GetMethod("get_AccumulatedValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_AccumulatedValue_0);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("Accumulate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Accumulate_1);
            args = new Type[]{};
            method = type.GetMethod("Consume", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Consume_2);
            args = new Type[]{typeof(Fusion.NetworkRunner)};
            method = type.GetMethod("ConsumeTickAligned", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ConsumeTickAligned_3);
            args = new Type[]{};
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_4);

            field = type.GetField("SmoothingWindow", flag);
            app.RegisterCLRFieldGetter(field, get_SmoothingWindow_0);
            app.RegisterCLRFieldSetter(field, set_SmoothingWindow_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_SmoothingWindow_0, AssignFromStack_SmoothingWindow_0);
            field = type.GetField("UseDirectionFilter", flag);
            app.RegisterCLRFieldGetter(field, get_UseDirectionFilter_1);
            app.RegisterCLRFieldSetter(field, set_UseDirectionFilter_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_UseDirectionFilter_1, AssignFromStack_UseDirectionFilter_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.Vector2Accumulator());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.Vector2Accumulator[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{typeof(System.Single)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);
            args = new Type[]{typeof(System.Single), typeof(System.Boolean)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_2);

        }


        static StackObject* get_AccumulatedValue_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.Vector2Accumulator instance_of_this_method = (Fusion.Addons.KCC.Vector2Accumulator)typeof(Fusion.Addons.KCC.Vector2Accumulator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AccumulatedValue;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Accumulate_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @value = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.Vector2Accumulator instance_of_this_method = (Fusion.Addons.KCC.Vector2Accumulator)typeof(Fusion.Addons.KCC.Vector2Accumulator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Accumulate(@value);

            return __ret;
        }

        static StackObject* Consume_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.Vector2Accumulator instance_of_this_method = (Fusion.Addons.KCC.Vector2Accumulator)typeof(Fusion.Addons.KCC.Vector2Accumulator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Consume();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ConsumeTickAligned_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkRunner @runner = (Fusion.NetworkRunner)typeof(Fusion.NetworkRunner).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.Vector2Accumulator instance_of_this_method = (Fusion.Addons.KCC.Vector2Accumulator)typeof(Fusion.Addons.KCC.Vector2Accumulator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ConsumeTickAligned(@runner);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Clear_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.Vector2Accumulator instance_of_this_method = (Fusion.Addons.KCC.Vector2Accumulator)typeof(Fusion.Addons.KCC.Vector2Accumulator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Clear();

            return __ret;
        }


        static object get_SmoothingWindow_0(ref object o)
        {
            return ((Fusion.Addons.KCC.Vector2Accumulator)o).SmoothingWindow;
        }

        static StackObject* CopyToStack_SmoothingWindow_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.Vector2Accumulator)o).SmoothingWindow;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_SmoothingWindow_0(ref object o, object v)
        {
            ((Fusion.Addons.KCC.Vector2Accumulator)o).SmoothingWindow = (System.Single)v;
        }

        static StackObject* AssignFromStack_SmoothingWindow_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @SmoothingWindow = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.Vector2Accumulator)o).SmoothingWindow = @SmoothingWindow;
            return ptr_of_this_method;
        }

        static object get_UseDirectionFilter_1(ref object o)
        {
            return ((Fusion.Addons.KCC.Vector2Accumulator)o).UseDirectionFilter;
        }

        static StackObject* CopyToStack_UseDirectionFilter_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.Vector2Accumulator)o).UseDirectionFilter;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_UseDirectionFilter_1(ref object o, object v)
        {
            ((Fusion.Addons.KCC.Vector2Accumulator)o).UseDirectionFilter = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_UseDirectionFilter_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @UseDirectionFilter = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.Vector2Accumulator)o).UseDirectionFilter = @UseDirectionFilter;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Addons.KCC.Vector2Accumulator();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @smoothingWindow = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = new Fusion.Addons.KCC.Vector2Accumulator(@smoothingWindow);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @useDirectionFilter = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @smoothingWindow = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = new Fusion.Addons.KCC.Vector2Accumulator(@smoothingWindow, @useDirectionFilter);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
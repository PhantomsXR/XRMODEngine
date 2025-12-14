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
    unsafe class LeanTest_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::LeanTest);
            args = new Type[]{typeof(System.String), typeof(System.Boolean), typeof(System.String)};
            method = type.GetMethod("debug", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, debug_0);
            args = new Type[]{typeof(System.Boolean), typeof(System.String), typeof(System.String)};
            method = type.GetMethod("expect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, expect_1);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("padRight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, padRight_2);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("printOutLength", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, printOutLength_3);
            args = new Type[]{typeof(System.String), typeof(System.String)};
            method = type.GetMethod("formatBC", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, formatBC_4);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("formatB", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, formatB_5);
            args = new Type[]{typeof(System.String), typeof(System.String)};
            method = type.GetMethod("formatC", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, formatC_6);
            args = new Type[]{};
            method = type.GetMethod("overview", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, overview_7);

            field = type.GetField("expected", flag);
            app.RegisterCLRFieldGetter(field, get_expected_0);
            app.RegisterCLRFieldSetter(field, set_expected_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_expected_0, AssignFromStack_expected_0);
            field = type.GetField("timeout", flag);
            app.RegisterCLRFieldGetter(field, get_timeout_1);
            app.RegisterCLRFieldSetter(field, set_timeout_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_timeout_1, AssignFromStack_timeout_1);
            field = type.GetField("timeoutStarted", flag);
            app.RegisterCLRFieldGetter(field, get_timeoutStarted_2);
            app.RegisterCLRFieldSetter(field, set_timeoutStarted_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_timeoutStarted_2, AssignFromStack_timeoutStarted_2);
            field = type.GetField("testsFinished", flag);
            app.RegisterCLRFieldGetter(field, get_testsFinished_3);
            app.RegisterCLRFieldSetter(field, set_testsFinished_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_testsFinished_3, AssignFromStack_testsFinished_3);


            app.RegisterCLRCreateDefaultInstance(type, () => new global::LeanTest());
            app.RegisterCLRCreateArrayInstance(type, s => new global::LeanTest[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* debug_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @failExplaination = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @didPass = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            global::LeanTest.debug(@name, @didPass, @failExplaination);

            return __ret;
        }

        static StackObject* expect_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @failExplaination = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @definition = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @didPass = ptr_of_this_method->Value == 1;


            global::LeanTest.expect(@didPass, @definition, @failExplaination);

            return __ret;
        }

        static StackObject* padRight_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @len = ptr_of_this_method->Value;


            var result_of_this_method = global::LeanTest.padRight(@len);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* printOutLength_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @str = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = global::LeanTest.printOutLength(@str);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* formatBC_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @color = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @str = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = global::LeanTest.formatBC(@str, @color);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* formatB_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @str = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = global::LeanTest.formatB(@str);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* formatC_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @color = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @str = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = global::LeanTest.formatC(@str, @color);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* overview_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            global::LeanTest.overview();

            return __ret;
        }


        static object get_expected_0(ref object o)
        {
            return global::LeanTest.expected;
        }

        static StackObject* CopyToStack_expected_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTest.expected;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_expected_0(ref object o, object v)
        {
            global::LeanTest.expected = (System.Int32)v;
        }

        static StackObject* AssignFromStack_expected_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @expected = ptr_of_this_method->Value;
            global::LeanTest.expected = @expected;
            return ptr_of_this_method;
        }

        static object get_timeout_1(ref object o)
        {
            return global::LeanTest.timeout;
        }

        static StackObject* CopyToStack_timeout_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTest.timeout;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_timeout_1(ref object o, object v)
        {
            global::LeanTest.timeout = (System.Single)v;
        }

        static StackObject* AssignFromStack_timeout_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @timeout = *(float*)&ptr_of_this_method->Value;
            global::LeanTest.timeout = @timeout;
            return ptr_of_this_method;
        }

        static object get_timeoutStarted_2(ref object o)
        {
            return global::LeanTest.timeoutStarted;
        }

        static StackObject* CopyToStack_timeoutStarted_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTest.timeoutStarted;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_timeoutStarted_2(ref object o, object v)
        {
            global::LeanTest.timeoutStarted = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_timeoutStarted_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @timeoutStarted = ptr_of_this_method->Value == 1;
            global::LeanTest.timeoutStarted = @timeoutStarted;
            return ptr_of_this_method;
        }

        static object get_testsFinished_3(ref object o)
        {
            return global::LeanTest.testsFinished;
        }

        static StackObject* CopyToStack_testsFinished_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LeanTest.testsFinished;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_testsFinished_3(ref object o, object v)
        {
            global::LeanTest.testsFinished = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_testsFinished_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @testsFinished = ptr_of_this_method->Value == 1;
            global::LeanTest.testsFinished = @testsFinished;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new global::LeanTest();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

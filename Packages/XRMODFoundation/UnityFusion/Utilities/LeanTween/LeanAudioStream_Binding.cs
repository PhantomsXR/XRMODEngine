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
    unsafe class LeanAudioStream_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::LeanAudioStream);
            args = new Type[]{typeof(System.Single[])};
            method = type.GetMethod("OnAudioRead", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnAudioRead_0);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("OnAudioSetPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnAudioSetPosition_1);

            field = type.GetField("position", flag);
            app.RegisterCLRFieldGetter(field, get_position_0);
            app.RegisterCLRFieldSetter(field, set_position_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_position_0, AssignFromStack_position_0);
            field = type.GetField("audioClip", flag);
            app.RegisterCLRFieldGetter(field, get_audioClip_1);
            app.RegisterCLRFieldSetter(field, set_audioClip_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_audioClip_1, AssignFromStack_audioClip_1);
            field = type.GetField("audioArr", flag);
            app.RegisterCLRFieldGetter(field, get_audioArr_2);
            app.RegisterCLRFieldSetter(field, set_audioArr_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_audioArr_2, AssignFromStack_audioArr_2);


            app.RegisterCLRCreateArrayInstance(type, s => new global::LeanAudioStream[s]);

            args = new Type[]{typeof(System.Single[])};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* OnAudioRead_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single[] @data = (System.Single[])typeof(System.Single[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LeanAudioStream instance_of_this_method = (global::LeanAudioStream)typeof(global::LeanAudioStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnAudioRead(@data);

            return __ret;
        }

        static StackObject* OnAudioSetPosition_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @newPosition = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LeanAudioStream instance_of_this_method = (global::LeanAudioStream)typeof(global::LeanAudioStream).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnAudioSetPosition(@newPosition);

            return __ret;
        }


        static object get_position_0(ref object o)
        {
            return ((global::LeanAudioStream)o).position;
        }

        static StackObject* CopyToStack_position_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LeanAudioStream)o).position;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_position_0(ref object o, object v)
        {
            ((global::LeanAudioStream)o).position = (System.Int32)v;
        }

        static StackObject* AssignFromStack_position_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @position = ptr_of_this_method->Value;
            ((global::LeanAudioStream)o).position = @position;
            return ptr_of_this_method;
        }

        static object get_audioClip_1(ref object o)
        {
            return ((global::LeanAudioStream)o).audioClip;
        }

        static StackObject* CopyToStack_audioClip_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LeanAudioStream)o).audioClip;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_audioClip_1(ref object o, object v)
        {
            ((global::LeanAudioStream)o).audioClip = (UnityEngine.AudioClip)v;
        }

        static StackObject* AssignFromStack_audioClip_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.AudioClip @audioClip = (UnityEngine.AudioClip)typeof(UnityEngine.AudioClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::LeanAudioStream)o).audioClip = @audioClip;
            return ptr_of_this_method;
        }

        static object get_audioArr_2(ref object o)
        {
            return ((global::LeanAudioStream)o).audioArr;
        }

        static StackObject* CopyToStack_audioArr_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LeanAudioStream)o).audioArr;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_audioArr_2(ref object o, object v)
        {
            ((global::LeanAudioStream)o).audioArr = (System.Single[])v;
        }

        static StackObject* AssignFromStack_audioArr_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single[] @audioArr = (System.Single[])typeof(System.Single[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::LeanAudioStream)o).audioArr = @audioArr;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single[] @audioArr = (System.Single[])typeof(System.Single[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new global::LeanAudioStream(@audioArr);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

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
    unsafe class Unity_AI_Navigation_CollectObjects_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.AI.Navigation.CollectObjects);

            field = type.GetField("All", flag);
            app.RegisterCLRFieldGetter(field, get_All_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_All_0, null);
            field = type.GetField("Volume", flag);
            app.RegisterCLRFieldGetter(field, get_Volume_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Volume_1, null);
            field = type.GetField("Children", flag);
            app.RegisterCLRFieldGetter(field, get_Children_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Children_2, null);
            field = type.GetField("MarkedWithModifier", flag);
            app.RegisterCLRFieldGetter(field, get_MarkedWithModifier_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_MarkedWithModifier_3, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.AI.Navigation.CollectObjects());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.AI.Navigation.CollectObjects[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Unity.AI.Navigation.CollectObjects instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Unity.AI.Navigation.CollectObjects[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_All_0(ref object o)
        {
            return Unity.AI.Navigation.CollectObjects.All;
        }

        static StackObject* CopyToStack_All_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.AI.Navigation.CollectObjects.All;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Volume_1(ref object o)
        {
            return Unity.AI.Navigation.CollectObjects.Volume;
        }

        static StackObject* CopyToStack_Volume_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.AI.Navigation.CollectObjects.Volume;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Children_2(ref object o)
        {
            return Unity.AI.Navigation.CollectObjects.Children;
        }

        static StackObject* CopyToStack_Children_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.AI.Navigation.CollectObjects.Children;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_MarkedWithModifier_3(ref object o)
        {
            return Unity.AI.Navigation.CollectObjects.MarkedWithModifier;
        }

        static StackObject* CopyToStack_MarkedWithModifier_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.AI.Navigation.CollectObjects.MarkedWithModifier;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Unity.AI.Navigation.CollectObjects();
            ins = (Unity.AI.Navigation.CollectObjects)o;
            return ins;
        }


    }
}

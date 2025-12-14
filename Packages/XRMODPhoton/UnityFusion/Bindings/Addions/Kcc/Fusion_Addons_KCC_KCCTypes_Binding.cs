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
    unsafe class Fusion_Addons_KCC_KCCTypes_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field; 
            Type type = typeof(Fusion.Addons.KCC.KCCTypes);

            field = type.GetField("IBeginMove", flag);
            app.RegisterCLRFieldGetter(field, get_IBeginMove_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_IBeginMove_0, null);
            field = type.GetField("BeginMove", flag);
            app.RegisterCLRFieldGetter(field, get_BeginMove_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_BeginMove_1, null);
            field = type.GetField("IPrepareData", flag);
            app.RegisterCLRFieldGetter(field, get_IPrepareData_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_IPrepareData_2, null);
            field = type.GetField("PrepareData", flag);
            app.RegisterCLRFieldGetter(field, get_PrepareData_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_PrepareData_3, null);
            field = type.GetField("IAfterMoveStep", flag);
            app.RegisterCLRFieldGetter(field, get_IAfterMoveStep_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_IAfterMoveStep_4, null);
            field = type.GetField("AfterMoveStep", flag);
            app.RegisterCLRFieldGetter(field, get_AfterMoveStep_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_AfterMoveStep_5, null);
            field = type.GetField("IEndMove", flag);
            app.RegisterCLRFieldGetter(field, get_IEndMove_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_IEndMove_6, null);
            field = type.GetField("EndMove", flag);
            app.RegisterCLRFieldGetter(field, get_EndMove_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_EndMove_7, null);




        }



        static object get_IBeginMove_0(ref object o)
        {
            return Fusion.Addons.KCC.KCCTypes.IBeginMove;
        }

        static StackObject* CopyToStack_IBeginMove_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCTypes.IBeginMove;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_BeginMove_1(ref object o)
        {
            return Fusion.Addons.KCC.KCCTypes.BeginMove;
        }

        static StackObject* CopyToStack_BeginMove_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCTypes.BeginMove;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_IPrepareData_2(ref object o)
        {
            return Fusion.Addons.KCC.KCCTypes.IPrepareData;
        }

        static StackObject* CopyToStack_IPrepareData_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCTypes.IPrepareData;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_PrepareData_3(ref object o)
        {
            return Fusion.Addons.KCC.KCCTypes.PrepareData;
        }

        static StackObject* CopyToStack_PrepareData_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCTypes.PrepareData;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_IAfterMoveStep_4(ref object o)
        {
            return Fusion.Addons.KCC.KCCTypes.IAfterMoveStep;
        }

        static StackObject* CopyToStack_IAfterMoveStep_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCTypes.IAfterMoveStep;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_AfterMoveStep_5(ref object o)
        {
            return Fusion.Addons.KCC.KCCTypes.AfterMoveStep;
        }

        static StackObject* CopyToStack_AfterMoveStep_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCTypes.AfterMoveStep;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_IEndMove_6(ref object o)
        {
            return Fusion.Addons.KCC.KCCTypes.IEndMove;
        }

        static StackObject* CopyToStack_IEndMove_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCTypes.IEndMove;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_EndMove_7(ref object o)
        {
            return Fusion.Addons.KCC.KCCTypes.EndMove;
        }

        static StackObject* CopyToStack_EndMove_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCTypes.EndMove;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




    }
}
#endif
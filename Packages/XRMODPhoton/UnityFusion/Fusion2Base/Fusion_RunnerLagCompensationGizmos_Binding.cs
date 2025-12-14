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
    unsafe class Fusion_RunnerLagCompensationGizmos_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.RunnerLagCompensationGizmos);

            field = type.GetField("DrawSnapshotHistory", flag);
            app.RegisterCLRFieldGetter(field, get_DrawSnapshotHistory_0);
            app.RegisterCLRFieldSetter(field, set_DrawSnapshotHistory_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_DrawSnapshotHistory_0, AssignFromStack_DrawSnapshotHistory_0);
            field = type.GetField("DrawBroadphaseNodes", flag);
            app.RegisterCLRFieldGetter(field, get_DrawBroadphaseNodes_1);
            app.RegisterCLRFieldSetter(field, set_DrawBroadphaseNodes_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_DrawBroadphaseNodes_1, AssignFromStack_DrawBroadphaseNodes_1);
            field = type.GetField("StateAuthHitboxCollor", flag);
            app.RegisterCLRFieldGetter(field, get_StateAuthHitboxCollor_2);
            app.RegisterCLRFieldSetter(field, set_StateAuthHitboxCollor_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_StateAuthHitboxCollor_2, AssignFromStack_StateAuthHitboxCollor_2);
            field = type.GetField("NonStateAuthHitboxCollor", flag);
            app.RegisterCLRFieldGetter(field, get_NonStateAuthHitboxCollor_3);
            app.RegisterCLRFieldSetter(field, set_NonStateAuthHitboxCollor_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_NonStateAuthHitboxCollor_3, AssignFromStack_NonStateAuthHitboxCollor_3);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.RunnerLagCompensationGizmos());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.RunnerLagCompensationGizmos[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_DrawSnapshotHistory_0(ref object o)
        {
            return ((Fusion.RunnerLagCompensationGizmos)o).DrawSnapshotHistory;
        }

        static StackObject* CopyToStack_DrawSnapshotHistory_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.RunnerLagCompensationGizmos)o).DrawSnapshotHistory;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_DrawSnapshotHistory_0(ref object o, object v)
        {
            ((Fusion.RunnerLagCompensationGizmos)o).DrawSnapshotHistory = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_DrawSnapshotHistory_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @DrawSnapshotHistory = ptr_of_this_method->Value == 1;
            ((Fusion.RunnerLagCompensationGizmos)o).DrawSnapshotHistory = @DrawSnapshotHistory;
            return ptr_of_this_method;
        }

        static object get_DrawBroadphaseNodes_1(ref object o)
        {
            return ((Fusion.RunnerLagCompensationGizmos)o).DrawBroadphaseNodes;
        }

        static StackObject* CopyToStack_DrawBroadphaseNodes_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.RunnerLagCompensationGizmos)o).DrawBroadphaseNodes;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_DrawBroadphaseNodes_1(ref object o, object v)
        {
            ((Fusion.RunnerLagCompensationGizmos)o).DrawBroadphaseNodes = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_DrawBroadphaseNodes_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @DrawBroadphaseNodes = ptr_of_this_method->Value == 1;
            ((Fusion.RunnerLagCompensationGizmos)o).DrawBroadphaseNodes = @DrawBroadphaseNodes;
            return ptr_of_this_method;
        }

        static object get_StateAuthHitboxCollor_2(ref object o)
        {
            return ((Fusion.RunnerLagCompensationGizmos)o).StateAuthHitboxCollor;
        }

        static StackObject* CopyToStack_StateAuthHitboxCollor_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.RunnerLagCompensationGizmos)o).StateAuthHitboxCollor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_StateAuthHitboxCollor_2(ref object o, object v)
        {
            ((Fusion.RunnerLagCompensationGizmos)o).StateAuthHitboxCollor = (UnityEngine.Color)v;
        }

        static StackObject* AssignFromStack_StateAuthHitboxCollor_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Color @StateAuthHitboxCollor = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.RunnerLagCompensationGizmos)o).StateAuthHitboxCollor = @StateAuthHitboxCollor;
            return ptr_of_this_method;
        }

        static object get_NonStateAuthHitboxCollor_3(ref object o)
        {
            return ((Fusion.RunnerLagCompensationGizmos)o).NonStateAuthHitboxCollor;
        }

        static StackObject* CopyToStack_NonStateAuthHitboxCollor_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.RunnerLagCompensationGizmos)o).NonStateAuthHitboxCollor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_NonStateAuthHitboxCollor_3(ref object o, object v)
        {
            ((Fusion.RunnerLagCompensationGizmos)o).NonStateAuthHitboxCollor = (UnityEngine.Color)v;
        }

        static StackObject* AssignFromStack_NonStateAuthHitboxCollor_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Color @NonStateAuthHitboxCollor = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.RunnerLagCompensationGizmos)o).NonStateAuthHitboxCollor = @NonStateAuthHitboxCollor;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.RunnerLagCompensationGizmos();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

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
    unsafe class Phantom_XRMOD_XRMODUtilites_Runtime_UniPool_PoolStack_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack);
            args = new Type[]{};
            method = type.GetMethod("get_CellRegistry", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_CellRegistry_0);
            args = new Type[]{typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell)};
            method = type.GetMethod("Push", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Push_1);
            args = new Type[]{typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell).MakeByRefType()};
            method = type.GetMethod("TryPop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryPop_2);
            args = new Type[]{typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell)};
            method = type.GetMethod("Remove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Remove_3);
            args = new Type[]{};
            method = type.GetMethod("RemoveAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveAll_4);
            args = new Type[]{typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell)};
            method = type.GetMethod("RegisterCell", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterCell_5);
            args = new Type[]{};
            method = type.GetMethod("GenerateCell", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GenerateCell_6);

            field = type.GetField("CellGenerator", flag);
            app.RegisterCLRFieldGetter(field, get_CellGenerator_0);
            app.RegisterCLRFieldSetter(field, set_CellGenerator_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_CellGenerator_0, AssignFromStack_CellGenerator_0);
            field = type.GetField("ActiveOnGet", flag);
            app.RegisterCLRFieldGetter(field, get_ActiveOnGet_1);
            app.RegisterCLRFieldSetter(field, set_ActiveOnGet_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_ActiveOnGet_1, AssignFromStack_ActiveOnGet_1);
            field = type.GetField("PrefabScale", flag);
            app.RegisterCLRFieldGetter(field, get_PrefabScale_2);
            app.RegisterCLRFieldSetter(field, set_PrefabScale_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_PrefabScale_2, AssignFromStack_PrefabScale_2);
            field = type.GetField("Container", flag);
            app.RegisterCLRFieldGetter(field, get_Container_3);
            app.RegisterCLRFieldSetter(field, set_Container_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Container_3, AssignFromStack_Container_3);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_CellRegistry_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack instance_of_this_method = (Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CellRegistry;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Push_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell @_cell = (Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell)typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack instance_of_this_method = (Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Push(@_cell);

            return __ret;
        }

        static StackObject* TryPop_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell @_cell = (Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell)typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack instance_of_this_method = (Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            var result_of_this_method = instance_of_this_method.TryPop(out @_cell);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @_cell;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @_cell;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @_cell);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @_cell;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @_cell);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @_cell;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Remove_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell @_cell = (Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell)typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack instance_of_this_method = (Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Remove(@_cell);

            return __ret;
        }

        static StackObject* RemoveAll_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack instance_of_this_method = (Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveAll();

            return __ret;
        }

        static StackObject* RegisterCell_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell @_cell = (Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell)typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack instance_of_this_method = (Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RegisterCell(@_cell);

            return __ret;
        }

        static StackObject* GenerateCell_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack instance_of_this_method = (Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GenerateCell();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_CellGenerator_0(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)o).CellGenerator;
        }

        static StackObject* CopyToStack_CellGenerator_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)o).CellGenerator;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_CellGenerator_0(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)o).CellGenerator = (System.Collections.IEnumerator)v;
        }

        static StackObject* AssignFromStack_CellGenerator_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.IEnumerator @CellGenerator = (System.Collections.IEnumerator)typeof(System.Collections.IEnumerator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)o).CellGenerator = @CellGenerator;
            return ptr_of_this_method;
        }

        static object get_ActiveOnGet_1(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)o).ActiveOnGet;
        }

        static StackObject* CopyToStack_ActiveOnGet_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)o).ActiveOnGet;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_ActiveOnGet_1(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)o).ActiveOnGet = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_ActiveOnGet_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @ActiveOnGet = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)o).ActiveOnGet = @ActiveOnGet;
            return ptr_of_this_method;
        }

        static object get_PrefabScale_2(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)o).PrefabScale;
        }

        static StackObject* CopyToStack_PrefabScale_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)o).PrefabScale;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PrefabScale_2(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)o).PrefabScale = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_PrefabScale_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @PrefabScale = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)o).PrefabScale = @PrefabScale;
            return ptr_of_this_method;
        }

        static object get_Container_3(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)o).Container;
        }

        static StackObject* CopyToStack_Container_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)o).Container;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Container_3(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)o).Container = (UnityEngine.Transform)v;
        }

        static StackObject* AssignFromStack_Container_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Transform @Container = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack)o).Container = @Container;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolStack();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

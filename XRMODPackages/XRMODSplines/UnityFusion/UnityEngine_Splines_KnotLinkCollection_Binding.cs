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
    unsafe class UnityEngine_Splines_KnotLinkCollection_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Splines.KnotLinkCollection);
            args = new Type[]{};
            method = type.GetMethod("get_Count", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Count_0);
            args = new Type[]{typeof(UnityEngine.Splines.SplineKnotIndex), typeof(System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.SplineKnotIndex>).MakeByRefType()};
            method = type.GetMethod("TryGetKnotLinks", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryGetKnotLinks_1);
            args = new Type[]{typeof(UnityEngine.Splines.SplineKnotIndex)};
            method = type.GetMethod("GetKnotLinks", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetKnotLinks_2);
            args = new Type[]{};
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_3);
            args = new Type[]{typeof(UnityEngine.Splines.SplineKnotIndex), typeof(UnityEngine.Splines.SplineKnotIndex)};
            method = type.GetMethod("Link", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Link_4);
            args = new Type[]{typeof(UnityEngine.Splines.SplineKnotIndex)};
            method = type.GetMethod("Unlink", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Unlink_5);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("SplineRemoved", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SplineRemoved_6);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("SplineIndexChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SplineIndexChanged_7);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("KnotIndexChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, KnotIndexChanged_8);
            args = new Type[]{typeof(UnityEngine.Splines.SplineKnotIndex), typeof(UnityEngine.Splines.SplineKnotIndex)};
            method = type.GetMethod("KnotIndexChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, KnotIndexChanged_9);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("KnotRemoved", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, KnotRemoved_10);
            args = new Type[]{typeof(UnityEngine.Splines.SplineKnotIndex)};
            method = type.GetMethod("KnotRemoved", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, KnotRemoved_11);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("KnotInserted", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, KnotInserted_12);
            args = new Type[]{typeof(UnityEngine.Splines.SplineKnotIndex)};
            method = type.GetMethod("KnotInserted", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, KnotInserted_13);
            args = new Type[]{typeof(UnityEngine.Splines.SplineKnotIndex), typeof(System.Int32)};
            method = type.GetMethod("ShiftKnotIndices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ShiftKnotIndices_14);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Splines.KnotLinkCollection());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Splines.KnotLinkCollection[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_Count_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.KnotLinkCollection instance_of_this_method = (UnityEngine.Splines.KnotLinkCollection)typeof(UnityEngine.Splines.KnotLinkCollection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Count;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* TryGetKnotLinks_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.SplineKnotIndex> @linkedKnots = (System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.SplineKnotIndex>)typeof(System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.SplineKnotIndex>).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineKnotIndex @knotIndex = (UnityEngine.Splines.SplineKnotIndex)typeof(UnityEngine.Splines.SplineKnotIndex).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Splines.KnotLinkCollection instance_of_this_method = (UnityEngine.Splines.KnotLinkCollection)typeof(UnityEngine.Splines.KnotLinkCollection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            var result_of_this_method = instance_of_this_method.TryGetKnotLinks(@knotIndex, out @linkedKnots);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @linkedKnots;
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
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @linkedKnots;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @linkedKnots);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @linkedKnots;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @linkedKnots);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Collections.Generic.IReadOnlyList<UnityEngine.Splines.SplineKnotIndex>[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @linkedKnots;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetKnotLinks_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineKnotIndex @knotIndex = (UnityEngine.Splines.SplineKnotIndex)typeof(UnityEngine.Splines.SplineKnotIndex).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.KnotLinkCollection instance_of_this_method = (UnityEngine.Splines.KnotLinkCollection)typeof(UnityEngine.Splines.KnotLinkCollection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetKnotLinks(@knotIndex);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Clear_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.KnotLinkCollection instance_of_this_method = (UnityEngine.Splines.KnotLinkCollection)typeof(UnityEngine.Splines.KnotLinkCollection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Clear();

            return __ret;
        }

        static StackObject* Link_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineKnotIndex @knotB = (UnityEngine.Splines.SplineKnotIndex)typeof(UnityEngine.Splines.SplineKnotIndex).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineKnotIndex @knotA = (UnityEngine.Splines.SplineKnotIndex)typeof(UnityEngine.Splines.SplineKnotIndex).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Splines.KnotLinkCollection instance_of_this_method = (UnityEngine.Splines.KnotLinkCollection)typeof(UnityEngine.Splines.KnotLinkCollection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Link(@knotA, @knotB);

            return __ret;
        }

        static StackObject* Unlink_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineKnotIndex @knot = (UnityEngine.Splines.SplineKnotIndex)typeof(UnityEngine.Splines.SplineKnotIndex).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.KnotLinkCollection instance_of_this_method = (UnityEngine.Splines.KnotLinkCollection)typeof(UnityEngine.Splines.KnotLinkCollection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Unlink(@knot);

            return __ret;
        }

        static StackObject* SplineRemoved_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @splineIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.KnotLinkCollection instance_of_this_method = (UnityEngine.Splines.KnotLinkCollection)typeof(UnityEngine.Splines.KnotLinkCollection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SplineRemoved(@splineIndex);

            return __ret;
        }

        static StackObject* SplineIndexChanged_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @newIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @previousIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Splines.KnotLinkCollection instance_of_this_method = (UnityEngine.Splines.KnotLinkCollection)typeof(UnityEngine.Splines.KnotLinkCollection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SplineIndexChanged(@previousIndex, @newIndex);

            return __ret;
        }

        static StackObject* KnotIndexChanged_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @newKnotIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @previousKnotIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @splineIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Splines.KnotLinkCollection instance_of_this_method = (UnityEngine.Splines.KnotLinkCollection)typeof(UnityEngine.Splines.KnotLinkCollection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.KnotIndexChanged(@splineIndex, @previousKnotIndex, @newKnotIndex);

            return __ret;
        }

        static StackObject* KnotIndexChanged_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineKnotIndex @newIndex = (UnityEngine.Splines.SplineKnotIndex)typeof(UnityEngine.Splines.SplineKnotIndex).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineKnotIndex @previousIndex = (UnityEngine.Splines.SplineKnotIndex)typeof(UnityEngine.Splines.SplineKnotIndex).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Splines.KnotLinkCollection instance_of_this_method = (UnityEngine.Splines.KnotLinkCollection)typeof(UnityEngine.Splines.KnotLinkCollection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.KnotIndexChanged(@previousIndex, @newIndex);

            return __ret;
        }

        static StackObject* KnotRemoved_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @knotIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @splineIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Splines.KnotLinkCollection instance_of_this_method = (UnityEngine.Splines.KnotLinkCollection)typeof(UnityEngine.Splines.KnotLinkCollection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.KnotRemoved(@splineIndex, @knotIndex);

            return __ret;
        }

        static StackObject* KnotRemoved_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineKnotIndex @index = (UnityEngine.Splines.SplineKnotIndex)typeof(UnityEngine.Splines.SplineKnotIndex).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.KnotLinkCollection instance_of_this_method = (UnityEngine.Splines.KnotLinkCollection)typeof(UnityEngine.Splines.KnotLinkCollection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.KnotRemoved(@index);

            return __ret;
        }

        static StackObject* KnotInserted_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @knotIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @splineIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Splines.KnotLinkCollection instance_of_this_method = (UnityEngine.Splines.KnotLinkCollection)typeof(UnityEngine.Splines.KnotLinkCollection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.KnotInserted(@splineIndex, @knotIndex);

            return __ret;
        }

        static StackObject* KnotInserted_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineKnotIndex @index = (UnityEngine.Splines.SplineKnotIndex)typeof(UnityEngine.Splines.SplineKnotIndex).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.KnotLinkCollection instance_of_this_method = (UnityEngine.Splines.KnotLinkCollection)typeof(UnityEngine.Splines.KnotLinkCollection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.KnotInserted(@index);

            return __ret;
        }

        static StackObject* ShiftKnotIndices_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @offset = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineKnotIndex @index = (UnityEngine.Splines.SplineKnotIndex)typeof(UnityEngine.Splines.SplineKnotIndex).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Splines.KnotLinkCollection instance_of_this_method = (UnityEngine.Splines.KnotLinkCollection)typeof(UnityEngine.Splines.KnotLinkCollection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ShiftKnotIndices(@index, @offset);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Splines.KnotLinkCollection();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

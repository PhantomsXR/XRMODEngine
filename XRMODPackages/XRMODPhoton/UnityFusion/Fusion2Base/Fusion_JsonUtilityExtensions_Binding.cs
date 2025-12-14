using System;
using System.Collections.Generic;
using System.Linq;
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
    unsafe class Fusion_JsonUtilityExtensions_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Fusion.JsonUtilityExtensions);
            MethodInfo[] methods = type.GetMethods(flag).Where(t => !t.IsGenericMethod).ToArray();
            args = new Type[]{typeof(System.String), typeof(System.Int32)};
            method = type.GetMethod("EnquoteIntegers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EnquoteIntegers_0);
            args = new Type[]{typeof(System.Object), typeof(Fusion.JsonUtilityExtensions.InstanceIDHandlerDelegate)};
            method = type.GetMethod("ToJsonWithTypeAnnotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToJsonWithTypeAnnotation_1);
            args = new Type[]{typeof(System.Object), typeof(System.IO.TextWriter), typeof(System.Nullable<System.Int32>), typeof(Fusion.JsonUtilityExtensions.TypeSerializerDelegate), typeof(Fusion.JsonUtilityExtensions.InstanceIDHandlerDelegate)};
            method = type.GetMethod("ToJsonWithTypeAnnotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToJsonWithTypeAnnotation_2);
            args = new Type[]{typeof(System.String), typeof(Fusion.JsonUtilityExtensions.TypeResolverDelegate)};
            method = methods.Where(t => t.Name.Equals("FromJsonWithTypeAnnotation") && t.CheckMethodParams(args)).Single();
            app.RegisterCLRMethodRedirection(method, FromJsonWithTypeAnnotation_3);





        }


        static StackObject* EnquoteIntegers_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @minDigits = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @json = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Fusion.JsonUtilityExtensions.EnquoteIntegers(@json, @minDigits);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToJsonWithTypeAnnotation_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.JsonUtilityExtensions.InstanceIDHandlerDelegate @instanceIDHandler = (Fusion.JsonUtilityExtensions.InstanceIDHandlerDelegate)typeof(Fusion.JsonUtilityExtensions.InstanceIDHandlerDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Object @obj = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Fusion.JsonUtilityExtensions.ToJsonWithTypeAnnotation(@obj, @instanceIDHandler);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ToJsonWithTypeAnnotation_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.JsonUtilityExtensions.InstanceIDHandlerDelegate @instanceIDHandler = (Fusion.JsonUtilityExtensions.InstanceIDHandlerDelegate)typeof(Fusion.JsonUtilityExtensions.InstanceIDHandlerDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.JsonUtilityExtensions.TypeSerializerDelegate @typeSerializer = (Fusion.JsonUtilityExtensions.TypeSerializerDelegate)typeof(Fusion.JsonUtilityExtensions.TypeSerializerDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Nullable<System.Int32> @integerEnquoteMinDigits = (System.Nullable<System.Int32>)typeof(System.Nullable<System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.IO.TextWriter @writer = (System.IO.TextWriter)typeof(System.IO.TextWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Object @obj = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Fusion.JsonUtilityExtensions.ToJsonWithTypeAnnotation(@obj, @writer, @integerEnquoteMinDigits, @typeSerializer, @instanceIDHandler);

            return __ret;
        }

        static StackObject* FromJsonWithTypeAnnotation_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.JsonUtilityExtensions.TypeResolverDelegate @typeResolver = (Fusion.JsonUtilityExtensions.TypeResolverDelegate)typeof(Fusion.JsonUtilityExtensions.TypeResolverDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @json = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Fusion.JsonUtilityExtensions.FromJsonWithTypeAnnotation(@json, @typeResolver);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance, true);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method, true);
        }





    }
}

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
    unsafe class UnityEngine_U2D_SpriteAtlasManager_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.U2D.SpriteAtlasManager);
            args = new Type[]{typeof(System.Action<System.String, System.Action<UnityEngine.U2D.SpriteAtlas>>)};
            method = type.GetMethod("add_atlasRequested", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_atlasRequested_0);
            args = new Type[]{typeof(System.Action<System.String, System.Action<UnityEngine.U2D.SpriteAtlas>>)};
            method = type.GetMethod("remove_atlasRequested", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_atlasRequested_1);
            args = new Type[]{typeof(System.Action<UnityEngine.U2D.SpriteAtlas>)};
            method = type.GetMethod("add_atlasRegistered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_atlasRegistered_2);
            args = new Type[]{typeof(System.Action<UnityEngine.U2D.SpriteAtlas>)};
            method = type.GetMethod("remove_atlasRegistered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_atlasRegistered_3);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.U2D.SpriteAtlasManager());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.U2D.SpriteAtlasManager[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* add_atlasRequested_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.String, System.Action<UnityEngine.U2D.SpriteAtlas>> @value = (System.Action<System.String, System.Action<UnityEngine.U2D.SpriteAtlas>>)typeof(System.Action<System.String, System.Action<UnityEngine.U2D.SpriteAtlas>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.U2D.SpriteAtlasManager.atlasRequested += value;

            return __ret;
        }

        static StackObject* remove_atlasRequested_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.String, System.Action<UnityEngine.U2D.SpriteAtlas>> @value = (System.Action<System.String, System.Action<UnityEngine.U2D.SpriteAtlas>>)typeof(System.Action<System.String, System.Action<UnityEngine.U2D.SpriteAtlas>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.U2D.SpriteAtlasManager.atlasRequested -= value;

            return __ret;
        }

        static StackObject* add_atlasRegistered_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.U2D.SpriteAtlas> @value = (System.Action<UnityEngine.U2D.SpriteAtlas>)typeof(System.Action<UnityEngine.U2D.SpriteAtlas>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.U2D.SpriteAtlasManager.atlasRegistered += value;

            return __ret;
        }

        static StackObject* remove_atlasRegistered_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.U2D.SpriteAtlas> @value = (System.Action<UnityEngine.U2D.SpriteAtlas>)typeof(System.Action<UnityEngine.U2D.SpriteAtlas>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.U2D.SpriteAtlasManager.atlasRegistered -= value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.U2D.SpriteAtlasManager();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

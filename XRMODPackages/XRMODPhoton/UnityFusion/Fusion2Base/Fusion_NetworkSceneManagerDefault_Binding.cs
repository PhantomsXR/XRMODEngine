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
    unsafe class Fusion_NetworkSceneManagerDefault_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.NetworkSceneManagerDefault);
            args = new Type[]{};
            method = type.GetMethod("get_MultiPeerScene", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MultiPeerScene_0);
            args = new Type[]{};
            method = type.GetMethod("get_MultiPeerDontDestroyOnLoadRoot", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MultiPeerDontDestroyOnLoadRoot_1);
            args = new Type[]{};
            method = type.GetMethod("get_Runner", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Runner_2);
            args = new Type[]{typeof(Fusion.NetworkRunner)};
            method = type.GetMethod("Initialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Initialize_3);
            args = new Type[]{};
            method = type.GetMethod("Shutdown", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Shutdown_4);
            args = new Type[]{};
            method = type.GetMethod("get_IsBusy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsBusy_5);
            args = new Type[]{};
            method = type.GetMethod("get_MainRunnerScene", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MainRunnerScene_6);
            args = new Type[]{typeof(UnityEngine.SceneManagement.Scene)};
            method = type.GetMethod("IsRunnerScene", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsRunnerScene_7);
            args = new Type[]{typeof(UnityEngine.PhysicsScene2D).MakeByRefType()};
            method = type.GetMethod("TryGetPhysicsScene2D", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryGetPhysicsScene2D_8);
            args = new Type[]{typeof(UnityEngine.PhysicsScene).MakeByRefType()};
            method = type.GetMethod("TryGetPhysicsScene3D", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryGetPhysicsScene3D_9);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("MakeDontDestroyOnLoad", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MakeDontDestroyOnLoad_10);
            args = new Type[]{typeof(UnityEngine.GameObject), typeof(Fusion.SceneRef)};
            method = type.GetMethod("MoveGameObjectToScene", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MoveGameObjectToScene_11);
            args = new Type[]{typeof(Fusion.SceneRef), typeof(Fusion.NetworkLoadSceneParameters)};
            method = type.GetMethod("LoadScene", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadScene_12);
            args = new Type[]{typeof(Fusion.SceneRef)};
            method = type.GetMethod("UnloadScene", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UnloadScene_13);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetSceneRef", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSceneRef_14);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("GetSceneRef", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSceneRef_15);
            args = new Type[]{typeof(Fusion.NetworkSceneInfo), typeof(Fusion.NetworkSceneInfoChangeSource)};
            method = type.GetMethod("OnSceneInfoChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnSceneInfoChanged_16);

            field = type.GetField("IsSceneTakeOverEnabled", flag);
            app.RegisterCLRFieldGetter(field, get_IsSceneTakeOverEnabled_0);
            app.RegisterCLRFieldSetter(field, set_IsSceneTakeOverEnabled_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsSceneTakeOverEnabled_0, AssignFromStack_IsSceneTakeOverEnabled_0);
            field = type.GetField("LogSceneLoadErrors", flag);
            app.RegisterCLRFieldGetter(field, get_LogSceneLoadErrors_1);
            app.RegisterCLRFieldSetter(field, set_LogSceneLoadErrors_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_LogSceneLoadErrors_1, AssignFromStack_LogSceneLoadErrors_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.NetworkSceneManagerDefault());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.NetworkSceneManagerDefault[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_MultiPeerScene_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkSceneManagerDefault instance_of_this_method = (Fusion.NetworkSceneManagerDefault)typeof(Fusion.NetworkSceneManagerDefault).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MultiPeerScene;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_MultiPeerDontDestroyOnLoadRoot_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkSceneManagerDefault instance_of_this_method = (Fusion.NetworkSceneManagerDefault)typeof(Fusion.NetworkSceneManagerDefault).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MultiPeerDontDestroyOnLoadRoot;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Runner_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkSceneManagerDefault instance_of_this_method = (Fusion.NetworkSceneManagerDefault)typeof(Fusion.NetworkSceneManagerDefault).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Runner;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Initialize_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkRunner @runner = (Fusion.NetworkRunner)typeof(Fusion.NetworkRunner).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.NetworkSceneManagerDefault instance_of_this_method = (Fusion.NetworkSceneManagerDefault)typeof(Fusion.NetworkSceneManagerDefault).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Initialize(@runner);

            return __ret;
        }

        static StackObject* Shutdown_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkSceneManagerDefault instance_of_this_method = (Fusion.NetworkSceneManagerDefault)typeof(Fusion.NetworkSceneManagerDefault).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Shutdown();

            return __ret;
        }

        static StackObject* get_IsBusy_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkSceneManagerDefault instance_of_this_method = (Fusion.NetworkSceneManagerDefault)typeof(Fusion.NetworkSceneManagerDefault).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsBusy;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_MainRunnerScene_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkSceneManagerDefault instance_of_this_method = (Fusion.NetworkSceneManagerDefault)typeof(Fusion.NetworkSceneManagerDefault).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MainRunnerScene;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* IsRunnerScene_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SceneManagement.Scene @scene = (UnityEngine.SceneManagement.Scene)typeof(UnityEngine.SceneManagement.Scene).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.NetworkSceneManagerDefault instance_of_this_method = (Fusion.NetworkSceneManagerDefault)typeof(Fusion.NetworkSceneManagerDefault).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsRunnerScene(@scene);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* TryGetPhysicsScene2D_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PhysicsScene2D @scene2D = (UnityEngine.PhysicsScene2D)typeof(UnityEngine.PhysicsScene2D).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.NetworkSceneManagerDefault instance_of_this_method = (Fusion.NetworkSceneManagerDefault)typeof(Fusion.NetworkSceneManagerDefault).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            var result_of_this_method = instance_of_this_method.TryGetPhysicsScene2D(out @scene2D);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @scene2D;
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
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @scene2D;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @scene2D);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @scene2D;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @scene2D);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.PhysicsScene2D[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @scene2D;
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

        static StackObject* TryGetPhysicsScene3D_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PhysicsScene @scene3D = (UnityEngine.PhysicsScene)typeof(UnityEngine.PhysicsScene).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.NetworkSceneManagerDefault instance_of_this_method = (Fusion.NetworkSceneManagerDefault)typeof(Fusion.NetworkSceneManagerDefault).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            var result_of_this_method = instance_of_this_method.TryGetPhysicsScene3D(out @scene3D);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @scene3D;
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
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @scene3D;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @scene3D);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @scene3D;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @scene3D);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.PhysicsScene[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @scene3D;
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

        static StackObject* MakeDontDestroyOnLoad_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @obj = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.NetworkSceneManagerDefault instance_of_this_method = (Fusion.NetworkSceneManagerDefault)typeof(Fusion.NetworkSceneManagerDefault).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MakeDontDestroyOnLoad(@obj);

            return __ret;
        }

        static StackObject* MoveGameObjectToScene_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.SceneRef @sceneRef = (Fusion.SceneRef)typeof(Fusion.SceneRef).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GameObject @gameObject = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.NetworkSceneManagerDefault instance_of_this_method = (Fusion.NetworkSceneManagerDefault)typeof(Fusion.NetworkSceneManagerDefault).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MoveGameObjectToScene(@gameObject, @sceneRef);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* LoadScene_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkLoadSceneParameters @parameters = (Fusion.NetworkLoadSceneParameters)typeof(Fusion.NetworkLoadSceneParameters).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.SceneRef @sceneRef = (Fusion.SceneRef)typeof(Fusion.SceneRef).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.NetworkSceneManagerDefault instance_of_this_method = (Fusion.NetworkSceneManagerDefault)typeof(Fusion.NetworkSceneManagerDefault).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LoadScene(@sceneRef, @parameters);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* UnloadScene_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.SceneRef @sceneRef = (Fusion.SceneRef)typeof(Fusion.SceneRef).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.NetworkSceneManagerDefault instance_of_this_method = (Fusion.NetworkSceneManagerDefault)typeof(Fusion.NetworkSceneManagerDefault).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.UnloadScene(@sceneRef);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetSceneRef_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @sceneNameOrPath = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.NetworkSceneManagerDefault instance_of_this_method = (Fusion.NetworkSceneManagerDefault)typeof(Fusion.NetworkSceneManagerDefault).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetSceneRef(@sceneNameOrPath);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetSceneRef_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @gameObject = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.NetworkSceneManagerDefault instance_of_this_method = (Fusion.NetworkSceneManagerDefault)typeof(Fusion.NetworkSceneManagerDefault).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetSceneRef(@gameObject);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OnSceneInfoChanged_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkSceneInfoChangeSource @changeSource = (Fusion.NetworkSceneInfoChangeSource)typeof(Fusion.NetworkSceneInfoChangeSource).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.NetworkSceneInfo @sceneInfo = (Fusion.NetworkSceneInfo)typeof(Fusion.NetworkSceneInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.NetworkSceneManagerDefault instance_of_this_method = (Fusion.NetworkSceneManagerDefault)typeof(Fusion.NetworkSceneManagerDefault).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.OnSceneInfoChanged(@sceneInfo, @changeSource);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


        static object get_IsSceneTakeOverEnabled_0(ref object o)
        {
            return ((Fusion.NetworkSceneManagerDefault)o).IsSceneTakeOverEnabled;
        }

        static StackObject* CopyToStack_IsSceneTakeOverEnabled_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.NetworkSceneManagerDefault)o).IsSceneTakeOverEnabled;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsSceneTakeOverEnabled_0(ref object o, object v)
        {
            ((Fusion.NetworkSceneManagerDefault)o).IsSceneTakeOverEnabled = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsSceneTakeOverEnabled_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsSceneTakeOverEnabled = ptr_of_this_method->Value == 1;
            ((Fusion.NetworkSceneManagerDefault)o).IsSceneTakeOverEnabled = @IsSceneTakeOverEnabled;
            return ptr_of_this_method;
        }

        static object get_LogSceneLoadErrors_1(ref object o)
        {
            return ((Fusion.NetworkSceneManagerDefault)o).LogSceneLoadErrors;
        }

        static StackObject* CopyToStack_LogSceneLoadErrors_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.NetworkSceneManagerDefault)o).LogSceneLoadErrors;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_LogSceneLoadErrors_1(ref object o, object v)
        {
            ((Fusion.NetworkSceneManagerDefault)o).LogSceneLoadErrors = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_LogSceneLoadErrors_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @LogSceneLoadErrors = ptr_of_this_method->Value == 1;
            ((Fusion.NetworkSceneManagerDefault)o).LogSceneLoadErrors = @LogSceneLoadErrors;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.NetworkSceneManagerDefault();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

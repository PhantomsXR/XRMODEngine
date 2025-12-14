#if USE_TIMELINE
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
    unsafe class UnityEngine_Timeline_ControlPlayableAsset_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Timeline.ControlPlayableAsset);
            args = new Type[]{};
            method = type.GetMethod("OnEnable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnEnable_0);
            args = new Type[]{};
            method = type.GetMethod("get_duration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_duration_1);
            args = new Type[]{};
            method = type.GetMethod("get_clipCaps", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_clipCaps_2);
            args = new Type[]{typeof(UnityEngine.Playables.PlayableGraph), typeof(UnityEngine.GameObject)};
            method = type.GetMethod("CreatePlayable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreatePlayable_3);
            args = new Type[]{typeof(UnityEngine.Playables.PlayableDirector), typeof(UnityEngine.Timeline.IPropertyCollector)};
            method = type.GetMethod("GatherProperties", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GatherProperties_4);

            field = type.GetField("sourceGameObject", flag);
            app.RegisterCLRFieldGetter(field, get_sourceGameObject_0);
            app.RegisterCLRFieldSetter(field, set_sourceGameObject_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_sourceGameObject_0, AssignFromStack_sourceGameObject_0);
            field = type.GetField("prefabGameObject", flag);
            app.RegisterCLRFieldGetter(field, get_prefabGameObject_1);
            app.RegisterCLRFieldSetter(field, set_prefabGameObject_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_prefabGameObject_1, AssignFromStack_prefabGameObject_1);
            field = type.GetField("updateParticle", flag);
            app.RegisterCLRFieldGetter(field, get_updateParticle_2);
            app.RegisterCLRFieldSetter(field, set_updateParticle_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_updateParticle_2, AssignFromStack_updateParticle_2);
            field = type.GetField("particleRandomSeed", flag);
            app.RegisterCLRFieldGetter(field, get_particleRandomSeed_3);
            app.RegisterCLRFieldSetter(field, set_particleRandomSeed_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_particleRandomSeed_3, AssignFromStack_particleRandomSeed_3);
            field = type.GetField("updateDirector", flag);
            app.RegisterCLRFieldGetter(field, get_updateDirector_4);
            app.RegisterCLRFieldSetter(field, set_updateDirector_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_updateDirector_4, AssignFromStack_updateDirector_4);
            field = type.GetField("updateITimeControl", flag);
            app.RegisterCLRFieldGetter(field, get_updateITimeControl_5);
            app.RegisterCLRFieldSetter(field, set_updateITimeControl_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_updateITimeControl_5, AssignFromStack_updateITimeControl_5);
            field = type.GetField("searchHierarchy", flag);
            app.RegisterCLRFieldGetter(field, get_searchHierarchy_6);
            app.RegisterCLRFieldSetter(field, set_searchHierarchy_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_searchHierarchy_6, AssignFromStack_searchHierarchy_6);
            field = type.GetField("active", flag);
            app.RegisterCLRFieldGetter(field, get_active_7);
            app.RegisterCLRFieldSetter(field, set_active_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_active_7, AssignFromStack_active_7);
            field = type.GetField("postPlayback", flag);
            app.RegisterCLRFieldGetter(field, get_postPlayback_8);
            app.RegisterCLRFieldSetter(field, set_postPlayback_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_postPlayback_8, AssignFromStack_postPlayback_8);
            field = type.GetField("directorOnClipEnd", flag);
            app.RegisterCLRFieldGetter(field, get_directorOnClipEnd_9);
            app.RegisterCLRFieldSetter(field, set_directorOnClipEnd_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_directorOnClipEnd_9, AssignFromStack_directorOnClipEnd_9);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Timeline.ControlPlayableAsset());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Timeline.ControlPlayableAsset[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* OnEnable_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.ControlPlayableAsset instance_of_this_method = (UnityEngine.Timeline.ControlPlayableAsset)typeof(UnityEngine.Timeline.ControlPlayableAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnEnable();

            return __ret;
        }

        static StackObject* get_duration_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.ControlPlayableAsset instance_of_this_method = (UnityEngine.Timeline.ControlPlayableAsset)typeof(UnityEngine.Timeline.ControlPlayableAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.duration;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_clipCaps_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.ControlPlayableAsset instance_of_this_method = (UnityEngine.Timeline.ControlPlayableAsset)typeof(UnityEngine.Timeline.ControlPlayableAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.clipCaps;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreatePlayable_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @go = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.PlayableGraph @graph = (UnityEngine.Playables.PlayableGraph)typeof(UnityEngine.Playables.PlayableGraph).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Timeline.ControlPlayableAsset instance_of_this_method = (UnityEngine.Timeline.ControlPlayableAsset)typeof(UnityEngine.Timeline.ControlPlayableAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CreatePlayable(@graph, @go);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GatherProperties_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Timeline.IPropertyCollector @driver = (UnityEngine.Timeline.IPropertyCollector)typeof(UnityEngine.Timeline.IPropertyCollector).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Playables.PlayableDirector @director = (UnityEngine.Playables.PlayableDirector)typeof(UnityEngine.Playables.PlayableDirector).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Timeline.ControlPlayableAsset instance_of_this_method = (UnityEngine.Timeline.ControlPlayableAsset)typeof(UnityEngine.Timeline.ControlPlayableAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.GatherProperties(@director, @driver);

            return __ret;
        }


        static object get_sourceGameObject_0(ref object o)
        {
            return ((UnityEngine.Timeline.ControlPlayableAsset)o).sourceGameObject;
        }

        static StackObject* CopyToStack_sourceGameObject_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Timeline.ControlPlayableAsset)o).sourceGameObject;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_sourceGameObject_0(ref object o, object v)
        {
            ((UnityEngine.Timeline.ControlPlayableAsset)o).sourceGameObject = (UnityEngine.ExposedReference<UnityEngine.GameObject>)v;
        }

        static StackObject* AssignFromStack_sourceGameObject_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.ExposedReference<UnityEngine.GameObject> @sourceGameObject = (UnityEngine.ExposedReference<UnityEngine.GameObject>)typeof(UnityEngine.ExposedReference<UnityEngine.GameObject>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((UnityEngine.Timeline.ControlPlayableAsset)o).sourceGameObject = @sourceGameObject;
            return ptr_of_this_method;
        }

        static object get_prefabGameObject_1(ref object o)
        {
            return ((UnityEngine.Timeline.ControlPlayableAsset)o).prefabGameObject;
        }

        static StackObject* CopyToStack_prefabGameObject_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Timeline.ControlPlayableAsset)o).prefabGameObject;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_prefabGameObject_1(ref object o, object v)
        {
            ((UnityEngine.Timeline.ControlPlayableAsset)o).prefabGameObject = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_prefabGameObject_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @prefabGameObject = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((UnityEngine.Timeline.ControlPlayableAsset)o).prefabGameObject = @prefabGameObject;
            return ptr_of_this_method;
        }

        static object get_updateParticle_2(ref object o)
        {
            return ((UnityEngine.Timeline.ControlPlayableAsset)o).updateParticle;
        }

        static StackObject* CopyToStack_updateParticle_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Timeline.ControlPlayableAsset)o).updateParticle;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_updateParticle_2(ref object o, object v)
        {
            ((UnityEngine.Timeline.ControlPlayableAsset)o).updateParticle = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_updateParticle_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @updateParticle = ptr_of_this_method->Value == 1;
            ((UnityEngine.Timeline.ControlPlayableAsset)o).updateParticle = @updateParticle;
            return ptr_of_this_method;
        }

        static object get_particleRandomSeed_3(ref object o)
        {
            return ((UnityEngine.Timeline.ControlPlayableAsset)o).particleRandomSeed;
        }

        static StackObject* CopyToStack_particleRandomSeed_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Timeline.ControlPlayableAsset)o).particleRandomSeed;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static void set_particleRandomSeed_3(ref object o, object v)
        {
            ((UnityEngine.Timeline.ControlPlayableAsset)o).particleRandomSeed = (System.UInt32)v;
        }

        static StackObject* AssignFromStack_particleRandomSeed_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.UInt32 @particleRandomSeed = (uint)ptr_of_this_method->Value;
            ((UnityEngine.Timeline.ControlPlayableAsset)o).particleRandomSeed = @particleRandomSeed;
            return ptr_of_this_method;
        }

        static object get_updateDirector_4(ref object o)
        {
            return ((UnityEngine.Timeline.ControlPlayableAsset)o).updateDirector;
        }

        static StackObject* CopyToStack_updateDirector_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Timeline.ControlPlayableAsset)o).updateDirector;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_updateDirector_4(ref object o, object v)
        {
            ((UnityEngine.Timeline.ControlPlayableAsset)o).updateDirector = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_updateDirector_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @updateDirector = ptr_of_this_method->Value == 1;
            ((UnityEngine.Timeline.ControlPlayableAsset)o).updateDirector = @updateDirector;
            return ptr_of_this_method;
        }

        static object get_updateITimeControl_5(ref object o)
        {
            return ((UnityEngine.Timeline.ControlPlayableAsset)o).updateITimeControl;
        }

        static StackObject* CopyToStack_updateITimeControl_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Timeline.ControlPlayableAsset)o).updateITimeControl;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_updateITimeControl_5(ref object o, object v)
        {
            ((UnityEngine.Timeline.ControlPlayableAsset)o).updateITimeControl = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_updateITimeControl_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @updateITimeControl = ptr_of_this_method->Value == 1;
            ((UnityEngine.Timeline.ControlPlayableAsset)o).updateITimeControl = @updateITimeControl;
            return ptr_of_this_method;
        }

        static object get_searchHierarchy_6(ref object o)
        {
            return ((UnityEngine.Timeline.ControlPlayableAsset)o).searchHierarchy;
        }

        static StackObject* CopyToStack_searchHierarchy_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Timeline.ControlPlayableAsset)o).searchHierarchy;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_searchHierarchy_6(ref object o, object v)
        {
            ((UnityEngine.Timeline.ControlPlayableAsset)o).searchHierarchy = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_searchHierarchy_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @searchHierarchy = ptr_of_this_method->Value == 1;
            ((UnityEngine.Timeline.ControlPlayableAsset)o).searchHierarchy = @searchHierarchy;
            return ptr_of_this_method;
        }

        static object get_active_7(ref object o)
        {
            return ((UnityEngine.Timeline.ControlPlayableAsset)o).active;
        }

        static StackObject* CopyToStack_active_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Timeline.ControlPlayableAsset)o).active;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_active_7(ref object o, object v)
        {
            ((UnityEngine.Timeline.ControlPlayableAsset)o).active = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_active_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @active = ptr_of_this_method->Value == 1;
            ((UnityEngine.Timeline.ControlPlayableAsset)o).active = @active;
            return ptr_of_this_method;
        }

        static object get_postPlayback_8(ref object o)
        {
            return ((UnityEngine.Timeline.ControlPlayableAsset)o).postPlayback;
        }

        static StackObject* CopyToStack_postPlayback_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Timeline.ControlPlayableAsset)o).postPlayback;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_postPlayback_8(ref object o, object v)
        {
            ((UnityEngine.Timeline.ControlPlayableAsset)o).postPlayback = (UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState)v;
        }

        static StackObject* AssignFromStack_postPlayback_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState @postPlayback = (UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState)typeof(UnityEngine.Timeline.ActivationControlPlayable.PostPlaybackState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((UnityEngine.Timeline.ControlPlayableAsset)o).postPlayback = @postPlayback;
            return ptr_of_this_method;
        }

        static object get_directorOnClipEnd_9(ref object o)
        {
            return ((UnityEngine.Timeline.ControlPlayableAsset)o).directorOnClipEnd;
        }

        static StackObject* CopyToStack_directorOnClipEnd_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Timeline.ControlPlayableAsset)o).directorOnClipEnd;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_directorOnClipEnd_9(ref object o, object v)
        {
            ((UnityEngine.Timeline.ControlPlayableAsset)o).directorOnClipEnd = (UnityEngine.Timeline.DirectorControlPlayable.PauseAction)v;
        }

        static StackObject* AssignFromStack_directorOnClipEnd_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Timeline.DirectorControlPlayable.PauseAction @directorOnClipEnd = (UnityEngine.Timeline.DirectorControlPlayable.PauseAction)typeof(UnityEngine.Timeline.DirectorControlPlayable.PauseAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((UnityEngine.Timeline.ControlPlayableAsset)o).directorOnClipEnd = @directorOnClipEnd;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Timeline.ControlPlayableAsset();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
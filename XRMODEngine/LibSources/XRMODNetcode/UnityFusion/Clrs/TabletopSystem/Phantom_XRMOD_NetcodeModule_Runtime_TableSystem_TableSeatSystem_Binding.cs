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
    unsafe class Phantom_XRMOD_NetcodeModule_Runtime_TableSystem_TableSeatSystem_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem);
            args = new Type[]{};
            method = type.GetMethod("get_TableTop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_TableTop_0);
            args = new Type[]{typeof(System.Action<System.Int32>)};
            method = type.GetMethod("Subscribe", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Subscribe_1);
            args = new Type[]{typeof(System.Action<System.Int32>)};
            method = type.GetMethod("Unsubscribe", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Unsubscribe_2);
            args = new Type[]{};
            method = type.GetMethod("get_DefaultSeatHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_DefaultSeatHeight_3);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_DefaultSeatHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_DefaultSeatHeight_4);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("TeleportToSeat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TeleportToSeat_5);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetRotationAngleBasedOnSeatId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRotationAngleBasedOnSeatId_6);



            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_TableTop_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem)typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TableTop;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Subscribe_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Int32> @_action = (System.Action<System.Int32>)typeof(System.Action<System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem)typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Subscribe(@_action);

            return __ret;
        }

        static StackObject* Unsubscribe_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Int32> @_action = (System.Action<System.Int32>)typeof(System.Action<System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem)typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Unsubscribe(@_action);

            return __ret;
        }

        static StackObject* get_DefaultSeatHeight_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem)typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DefaultSeatHeight;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_DefaultSeatHeight_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem)typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DefaultSeatHeight = value;

            return __ret;
        }

        static StackObject* TeleportToSeat_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @_seatId = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem)typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.TeleportToSeat(@_seatId);

            return __ret;
        }

        static StackObject* GetRotationAngleBasedOnSeatId_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @_seatId = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem)typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetRotationAngleBasedOnSeatId(@_seatId);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableSeatSystem();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

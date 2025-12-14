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
    unsafe class Phantom_XRMOD_NetcodeModule_Runtime_TableSystem_TableTop_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop);
            args = new Type[]{};
            method = type.GetMethod("get_Seats", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Seats_0);
            args = new Type[]{};
            method = type.GetMethod("get_SeatDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_SeatDistance_1);
            args = new Type[]{};
            method = type.GetMethod("get_SeatOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_SeatOffset_2);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_SeatOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_SeatOffset_3);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetSeat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSeat_4);

            field = type.GetField("CurrentSeatId", flag);
            app.RegisterCLRFieldGetter(field, get_CurrentSeatId_0);
            app.RegisterCLRFieldSetter(field, set_CurrentSeatId_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_CurrentSeatId_0, AssignFromStack_CurrentSeatId_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_Seats_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop)typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Seats;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_SeatDistance_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop)typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SeatDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_SeatOffset_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop)typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SeatOffset;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_SeatOffset_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop)typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SeatOffset = value;

            return __ret;
        }

        static StackObject* GetSeat_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @_seatId = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop)typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetSeat(@_seatId);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_CurrentSeatId_0(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop)o).CurrentSeatId;
        }

        static StackObject* CopyToStack_CurrentSeatId_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop)o).CurrentSeatId;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_CurrentSeatId_0(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop)o).CurrentSeatId = (System.Int32)v;
        }

        static StackObject* AssignFromStack_CurrentSeatId_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @CurrentSeatId = ptr_of_this_method->Value;
            ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop)o).CurrentSeatId = @CurrentSeatId;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTop();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

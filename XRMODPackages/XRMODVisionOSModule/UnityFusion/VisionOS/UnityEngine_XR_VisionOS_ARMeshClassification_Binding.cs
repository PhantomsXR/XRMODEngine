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
    unsafe class UnityEngine_XR_VisionOS_ARMeshClassification_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.XR.VisionOS.ARMeshClassification);

            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_None_0, null);
            field = type.GetField("Wall", flag);
            app.RegisterCLRFieldGetter(field, get_Wall_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Wall_1, null);
            field = type.GetField("Floor", flag);
            app.RegisterCLRFieldGetter(field, get_Floor_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Floor_2, null);
            field = type.GetField("Ceiling", flag);
            app.RegisterCLRFieldGetter(field, get_Ceiling_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Ceiling_3, null);
            field = type.GetField("Table", flag);
            app.RegisterCLRFieldGetter(field, get_Table_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Table_4, null);
            field = type.GetField("Seat", flag);
            app.RegisterCLRFieldGetter(field, get_Seat_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_Seat_5, null);
            field = type.GetField("Window", flag);
            app.RegisterCLRFieldGetter(field, get_Window_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_Window_6, null);
            field = type.GetField("Door", flag);
            app.RegisterCLRFieldGetter(field, get_Door_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_Door_7, null);
            field = type.GetField("WallDecoration", flag);
            app.RegisterCLRFieldGetter(field, get_WallDecoration_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_WallDecoration_8, null);
            field = type.GetField("Blinds", flag);
            app.RegisterCLRFieldGetter(field, get_Blinds_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_Blinds_9, null);
            field = type.GetField("Fireplace", flag);
            app.RegisterCLRFieldGetter(field, get_Fireplace_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_Fireplace_10, null);
            field = type.GetField("Stairs", flag);
            app.RegisterCLRFieldGetter(field, get_Stairs_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_Stairs_11, null);
            field = type.GetField("Bed", flag);
            app.RegisterCLRFieldGetter(field, get_Bed_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_Bed_12, null);
            field = type.GetField("Counter", flag);
            app.RegisterCLRFieldGetter(field, get_Counter_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_Counter_13, null);
            field = type.GetField("Cabinet", flag);
            app.RegisterCLRFieldGetter(field, get_Cabinet_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_Cabinet_14, null);
            field = type.GetField("HomeAppliance", flag);
            app.RegisterCLRFieldGetter(field, get_HomeAppliance_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_HomeAppliance_15, null);
            field = type.GetField("DoorFrame", flag);
            app.RegisterCLRFieldGetter(field, get_DoorFrame_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_DoorFrame_16, null);
            field = type.GetField("TV", flag);
            app.RegisterCLRFieldGetter(field, get_TV_17);
            app.RegisterCLRFieldBinding(field, CopyToStack_TV_17, null);
            field = type.GetField("Whiteboard", flag);
            app.RegisterCLRFieldGetter(field, get_Whiteboard_18);
            app.RegisterCLRFieldBinding(field, CopyToStack_Whiteboard_18, null);
            field = type.GetField("Plant", flag);
            app.RegisterCLRFieldGetter(field, get_Plant_19);
            app.RegisterCLRFieldBinding(field, CopyToStack_Plant_19, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.VisionOS.ARMeshClassification());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.VisionOS.ARMeshClassification[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.XR.VisionOS.ARMeshClassification instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.XR.VisionOS.ARMeshClassification[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_None_0(ref object o)
        {
            return UnityEngine.XR.VisionOS.ARMeshClassification.None;
        }

        static StackObject* CopyToStack_None_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.ARMeshClassification.None;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Wall_1(ref object o)
        {
            return UnityEngine.XR.VisionOS.ARMeshClassification.Wall;
        }

        static StackObject* CopyToStack_Wall_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.ARMeshClassification.Wall;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Floor_2(ref object o)
        {
            return UnityEngine.XR.VisionOS.ARMeshClassification.Floor;
        }

        static StackObject* CopyToStack_Floor_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.ARMeshClassification.Floor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Ceiling_3(ref object o)
        {
            return UnityEngine.XR.VisionOS.ARMeshClassification.Ceiling;
        }

        static StackObject* CopyToStack_Ceiling_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.ARMeshClassification.Ceiling;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Table_4(ref object o)
        {
            return UnityEngine.XR.VisionOS.ARMeshClassification.Table;
        }

        static StackObject* CopyToStack_Table_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.ARMeshClassification.Table;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Seat_5(ref object o)
        {
            return UnityEngine.XR.VisionOS.ARMeshClassification.Seat;
        }

        static StackObject* CopyToStack_Seat_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.ARMeshClassification.Seat;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Window_6(ref object o)
        {
            return UnityEngine.XR.VisionOS.ARMeshClassification.Window;
        }

        static StackObject* CopyToStack_Window_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.ARMeshClassification.Window;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Door_7(ref object o)
        {
            return UnityEngine.XR.VisionOS.ARMeshClassification.Door;
        }

        static StackObject* CopyToStack_Door_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.ARMeshClassification.Door;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_WallDecoration_8(ref object o)
        {
            return UnityEngine.XR.VisionOS.ARMeshClassification.WallDecoration;
        }

        static StackObject* CopyToStack_WallDecoration_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.ARMeshClassification.WallDecoration;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Blinds_9(ref object o)
        {
            return UnityEngine.XR.VisionOS.ARMeshClassification.Blinds;
        }

        static StackObject* CopyToStack_Blinds_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.ARMeshClassification.Blinds;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Fireplace_10(ref object o)
        {
            return UnityEngine.XR.VisionOS.ARMeshClassification.Fireplace;
        }

        static StackObject* CopyToStack_Fireplace_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.ARMeshClassification.Fireplace;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Stairs_11(ref object o)
        {
            return UnityEngine.XR.VisionOS.ARMeshClassification.Stairs;
        }

        static StackObject* CopyToStack_Stairs_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.ARMeshClassification.Stairs;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Bed_12(ref object o)
        {
            return UnityEngine.XR.VisionOS.ARMeshClassification.Bed;
        }

        static StackObject* CopyToStack_Bed_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.ARMeshClassification.Bed;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Counter_13(ref object o)
        {
            return UnityEngine.XR.VisionOS.ARMeshClassification.Counter;
        }

        static StackObject* CopyToStack_Counter_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.ARMeshClassification.Counter;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Cabinet_14(ref object o)
        {
            return UnityEngine.XR.VisionOS.ARMeshClassification.Cabinet;
        }

        static StackObject* CopyToStack_Cabinet_14(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.ARMeshClassification.Cabinet;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_HomeAppliance_15(ref object o)
        {
            return UnityEngine.XR.VisionOS.ARMeshClassification.HomeAppliance;
        }

        static StackObject* CopyToStack_HomeAppliance_15(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.ARMeshClassification.HomeAppliance;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_DoorFrame_16(ref object o)
        {
            return UnityEngine.XR.VisionOS.ARMeshClassification.DoorFrame;
        }

        static StackObject* CopyToStack_DoorFrame_16(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.ARMeshClassification.DoorFrame;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_TV_17(ref object o)
        {
            return UnityEngine.XR.VisionOS.ARMeshClassification.TV;
        }

        static StackObject* CopyToStack_TV_17(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.ARMeshClassification.TV;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Whiteboard_18(ref object o)
        {
            return UnityEngine.XR.VisionOS.ARMeshClassification.Whiteboard;
        }

        static StackObject* CopyToStack_Whiteboard_18(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.ARMeshClassification.Whiteboard;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Plant_19(ref object o)
        {
            return UnityEngine.XR.VisionOS.ARMeshClassification.Plant;
        }

        static StackObject* CopyToStack_Plant_19(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.ARMeshClassification.Plant;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.XR.VisionOS.ARMeshClassification();
            ins = (UnityEngine.XR.VisionOS.ARMeshClassification)o;
            return ins;
        }


    }
}

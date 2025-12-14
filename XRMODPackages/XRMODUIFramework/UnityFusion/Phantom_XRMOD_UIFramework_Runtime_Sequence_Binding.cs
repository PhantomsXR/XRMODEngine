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
    unsafe class Phantom_XRMOD_UIFramework_Runtime_Sequence_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence);
            args = new Type[]{};
            method = type.GetMethod("Init", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Init_0);

            field = type.GetField("AtTime", flag);
            app.RegisterCLRFieldGetter(field, get_AtTime_0);
            app.RegisterCLRFieldSetter(field, set_AtTime_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_AtTime_0, AssignFromStack_AtTime_0);
            field = type.GetField("StartTime", flag);
            app.RegisterCLRFieldGetter(field, get_StartTime_1);
            app.RegisterCLRFieldSetter(field, set_StartTime_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_StartTime_1, AssignFromStack_StartTime_1);
            field = type.GetField("TriggerStart", flag);
            app.RegisterCLRFieldGetter(field, get_TriggerStart_2);
            app.RegisterCLRFieldSetter(field, set_TriggerStart_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_TriggerStart_2, AssignFromStack_TriggerStart_2);
            field = type.GetField("TriggerEnd", flag);
            app.RegisterCLRFieldGetter(field, get_TriggerEnd_3);
            app.RegisterCLRFieldSetter(field, set_TriggerEnd_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_TriggerEnd_3, AssignFromStack_TriggerEnd_3);
            field = type.GetField("PropertyRectHeight", flag);
            app.RegisterCLRFieldGetter(field, get_PropertyRectHeight_4);
            app.RegisterCLRFieldSetter(field, set_PropertyRectHeight_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_PropertyRectHeight_4, AssignFromStack_PropertyRectHeight_4);
            field = type.GetField("PropertyRectY", flag);
            app.RegisterCLRFieldGetter(field, get_PropertyRectY_5);
            app.RegisterCLRFieldSetter(field, set_PropertyRectY_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_PropertyRectY_5, AssignFromStack_PropertyRectY_5);
            field = type.GetField("SequenceType", flag);
            app.RegisterCLRFieldGetter(field, get_SequenceType_6);
            app.RegisterCLRFieldSetter(field, set_SequenceType_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_SequenceType_6, AssignFromStack_SequenceType_6);
            field = type.GetField("EaseType", flag);
            app.RegisterCLRFieldGetter(field, get_EaseType_7);
            app.RegisterCLRFieldSetter(field, set_EaseType_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_EaseType_7, AssignFromStack_EaseType_7);
            field = type.GetField("EasePower", flag);
            app.RegisterCLRFieldGetter(field, get_EasePower_8);
            app.RegisterCLRFieldSetter(field, set_EasePower_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_EasePower_8, AssignFromStack_EasePower_8);
            field = type.GetField("TargetType", flag);
            app.RegisterCLRFieldGetter(field, get_TargetType_9);
            app.RegisterCLRFieldSetter(field, set_TargetType_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_TargetType_9, AssignFromStack_TargetType_9);
            field = type.GetField("TargetComp", flag);
            app.RegisterCLRFieldGetter(field, get_TargetComp_10);
            app.RegisterCLRFieldSetter(field, set_TargetComp_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_TargetComp_10, AssignFromStack_TargetComp_10);
            field = type.GetField("Duration", flag);
            app.RegisterCLRFieldGetter(field, get_Duration_11);
            app.RegisterCLRFieldSetter(field, set_Duration_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_Duration_11, AssignFromStack_Duration_11);
            field = type.GetField("EventDynamic", flag);
            app.RegisterCLRFieldGetter(field, get_EventDynamic_12);
            app.RegisterCLRFieldSetter(field, set_EventDynamic_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_EventDynamic_12, AssignFromStack_EventDynamic_12);
            field = type.GetField("IsUnfolded", flag);
            app.RegisterCLRFieldGetter(field, get_IsUnfolded_13);
            app.RegisterCLRFieldSetter(field, set_IsUnfolded_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsUnfolded_13, AssignFromStack_IsUnfolded_13);
            field = type.GetField("IsDone", flag);
            app.RegisterCLRFieldGetter(field, get_IsDone_14);
            app.RegisterCLRFieldSetter(field, set_IsDone_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsDone_14, AssignFromStack_IsDone_14);
            field = type.GetField("Target", flag);
            app.RegisterCLRFieldGetter(field, get_Target_15);
            app.RegisterCLRFieldSetter(field, set_Target_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_Target_15, AssignFromStack_Target_15);
            field = type.GetField("IsActivating", flag);
            app.RegisterCLRFieldGetter(field, get_IsActivating_16);
            app.RegisterCLRFieldSetter(field, set_IsActivating_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsActivating_16, AssignFromStack_IsActivating_16);
            field = type.GetField("PlaySFXBy", flag);
            app.RegisterCLRFieldGetter(field, get_PlaySFXBy_17);
            app.RegisterCLRFieldSetter(field, set_PlaySFXBy_17);
            app.RegisterCLRFieldBinding(field, CopyToStack_PlaySFXBy_17, AssignFromStack_PlaySFXBy_17);
            field = type.GetField("SFXFile", flag);
            app.RegisterCLRFieldGetter(field, get_SFXFile_18);
            app.RegisterCLRFieldSetter(field, set_SFXFile_18);
            app.RegisterCLRFieldBinding(field, CopyToStack_SFXFile_18, AssignFromStack_SFXFile_18);
            field = type.GetField("SFXIndex", flag);
            app.RegisterCLRFieldGetter(field, get_SFXIndex_19);
            app.RegisterCLRFieldSetter(field, set_SFXIndex_19);
            app.RegisterCLRFieldBinding(field, CopyToStack_SFXIndex_19, AssignFromStack_SFXIndex_19);
            field = type.GetField("SceneToLoad", flag);
            app.RegisterCLRFieldGetter(field, get_SceneToLoad_20);
            app.RegisterCLRFieldSetter(field, set_SceneToLoad_20);
            app.RegisterCLRFieldBinding(field, CopyToStack_SceneToLoad_20, AssignFromStack_SceneToLoad_20);
            field = type.GetField("Event", flag);
            app.RegisterCLRFieldGetter(field, get_Event_21);
            app.RegisterCLRFieldSetter(field, set_Event_21);
            app.RegisterCLRFieldBinding(field, CopyToStack_Event_21, AssignFromStack_Event_21);
            field = type.GetField("TargetRtTask", flag);
            app.RegisterCLRFieldGetter(field, get_TargetRtTask_22);
            app.RegisterCLRFieldSetter(field, set_TargetRtTask_22);
            app.RegisterCLRFieldBinding(field, CopyToStack_TargetRtTask_22, AssignFromStack_TargetRtTask_22);
            field = type.GetField("AnchoredPositionState", flag);
            app.RegisterCLRFieldGetter(field, get_AnchoredPositionState_23);
            app.RegisterCLRFieldSetter(field, set_AnchoredPositionState_23);
            app.RegisterCLRFieldBinding(field, CopyToStack_AnchoredPositionState_23, AssignFromStack_AnchoredPositionState_23);
            field = type.GetField("AnchoredPositionStart", flag);
            app.RegisterCLRFieldGetter(field, get_AnchoredPositionStart_24);
            app.RegisterCLRFieldSetter(field, set_AnchoredPositionStart_24);
            app.RegisterCLRFieldBinding(field, CopyToStack_AnchoredPositionStart_24, AssignFromStack_AnchoredPositionStart_24);
            field = type.GetField("AnchoredPositionEnd", flag);
            app.RegisterCLRFieldGetter(field, get_AnchoredPositionEnd_25);
            app.RegisterCLRFieldSetter(field, set_AnchoredPositionEnd_25);
            app.RegisterCLRFieldBinding(field, CopyToStack_AnchoredPositionEnd_25, AssignFromStack_AnchoredPositionEnd_25);
            field = type.GetField("LocalScaleState", flag);
            app.RegisterCLRFieldGetter(field, get_LocalScaleState_26);
            app.RegisterCLRFieldSetter(field, set_LocalScaleState_26);
            app.RegisterCLRFieldBinding(field, CopyToStack_LocalScaleState_26, AssignFromStack_LocalScaleState_26);
            field = type.GetField("LocalScaleStart", flag);
            app.RegisterCLRFieldGetter(field, get_LocalScaleStart_27);
            app.RegisterCLRFieldSetter(field, set_LocalScaleStart_27);
            app.RegisterCLRFieldBinding(field, CopyToStack_LocalScaleStart_27, AssignFromStack_LocalScaleStart_27);
            field = type.GetField("LocalScaleEnd", flag);
            app.RegisterCLRFieldGetter(field, get_LocalScaleEnd_28);
            app.RegisterCLRFieldSetter(field, set_LocalScaleEnd_28);
            app.RegisterCLRFieldBinding(field, CopyToStack_LocalScaleEnd_28, AssignFromStack_LocalScaleEnd_28);
            field = type.GetField("LocalEulerAnglesState", flag);
            app.RegisterCLRFieldGetter(field, get_LocalEulerAnglesState_29);
            app.RegisterCLRFieldSetter(field, set_LocalEulerAnglesState_29);
            app.RegisterCLRFieldBinding(field, CopyToStack_LocalEulerAnglesState_29, AssignFromStack_LocalEulerAnglesState_29);
            field = type.GetField("LocalEulerAnglesStart", flag);
            app.RegisterCLRFieldGetter(field, get_LocalEulerAnglesStart_30);
            app.RegisterCLRFieldSetter(field, set_LocalEulerAnglesStart_30);
            app.RegisterCLRFieldBinding(field, CopyToStack_LocalEulerAnglesStart_30, AssignFromStack_LocalEulerAnglesStart_30);
            field = type.GetField("LocalEulerAnglesEnd", flag);
            app.RegisterCLRFieldGetter(field, get_LocalEulerAnglesEnd_31);
            app.RegisterCLRFieldSetter(field, set_LocalEulerAnglesEnd_31);
            app.RegisterCLRFieldBinding(field, CopyToStack_LocalEulerAnglesEnd_31, AssignFromStack_LocalEulerAnglesEnd_31);
            field = type.GetField("SizeDeltaState", flag);
            app.RegisterCLRFieldGetter(field, get_SizeDeltaState_32);
            app.RegisterCLRFieldSetter(field, set_SizeDeltaState_32);
            app.RegisterCLRFieldBinding(field, CopyToStack_SizeDeltaState_32, AssignFromStack_SizeDeltaState_32);
            field = type.GetField("SizeDeltaStart", flag);
            app.RegisterCLRFieldGetter(field, get_SizeDeltaStart_33);
            app.RegisterCLRFieldSetter(field, set_SizeDeltaStart_33);
            app.RegisterCLRFieldBinding(field, CopyToStack_SizeDeltaStart_33, AssignFromStack_SizeDeltaStart_33);
            field = type.GetField("SizeDeltaEnd", flag);
            app.RegisterCLRFieldGetter(field, get_SizeDeltaEnd_34);
            app.RegisterCLRFieldSetter(field, set_SizeDeltaEnd_34);
            app.RegisterCLRFieldBinding(field, CopyToStack_SizeDeltaEnd_34, AssignFromStack_SizeDeltaEnd_34);
            field = type.GetField("AnchorMinState", flag);
            app.RegisterCLRFieldGetter(field, get_AnchorMinState_35);
            app.RegisterCLRFieldSetter(field, set_AnchorMinState_35);
            app.RegisterCLRFieldBinding(field, CopyToStack_AnchorMinState_35, AssignFromStack_AnchorMinState_35);
            field = type.GetField("AnchorMinStart", flag);
            app.RegisterCLRFieldGetter(field, get_AnchorMinStart_36);
            app.RegisterCLRFieldSetter(field, set_AnchorMinStart_36);
            app.RegisterCLRFieldBinding(field, CopyToStack_AnchorMinStart_36, AssignFromStack_AnchorMinStart_36);
            field = type.GetField("AnchorMinEnd", flag);
            app.RegisterCLRFieldGetter(field, get_AnchorMinEnd_37);
            app.RegisterCLRFieldSetter(field, set_AnchorMinEnd_37);
            app.RegisterCLRFieldBinding(field, CopyToStack_AnchorMinEnd_37, AssignFromStack_AnchorMinEnd_37);
            field = type.GetField("AnchorMaxState", flag);
            app.RegisterCLRFieldGetter(field, get_AnchorMaxState_38);
            app.RegisterCLRFieldSetter(field, set_AnchorMaxState_38);
            app.RegisterCLRFieldBinding(field, CopyToStack_AnchorMaxState_38, AssignFromStack_AnchorMaxState_38);
            field = type.GetField("AnchorMaxStart", flag);
            app.RegisterCLRFieldGetter(field, get_AnchorMaxStart_39);
            app.RegisterCLRFieldSetter(field, set_AnchorMaxStart_39);
            app.RegisterCLRFieldBinding(field, CopyToStack_AnchorMaxStart_39, AssignFromStack_AnchorMaxStart_39);
            field = type.GetField("AnchorMaxEnd", flag);
            app.RegisterCLRFieldGetter(field, get_AnchorMaxEnd_40);
            app.RegisterCLRFieldSetter(field, set_AnchorMaxEnd_40);
            app.RegisterCLRFieldBinding(field, CopyToStack_AnchorMaxEnd_40, AssignFromStack_AnchorMaxEnd_40);
            field = type.GetField("PivotState", flag);
            app.RegisterCLRFieldGetter(field, get_PivotState_41);
            app.RegisterCLRFieldSetter(field, set_PivotState_41);
            app.RegisterCLRFieldBinding(field, CopyToStack_PivotState_41, AssignFromStack_PivotState_41);
            field = type.GetField("PivotStart", flag);
            app.RegisterCLRFieldGetter(field, get_PivotStart_42);
            app.RegisterCLRFieldSetter(field, set_PivotStart_42);
            app.RegisterCLRFieldBinding(field, CopyToStack_PivotStart_42, AssignFromStack_PivotStart_42);
            field = type.GetField("PivotEnd", flag);
            app.RegisterCLRFieldGetter(field, get_PivotEnd_43);
            app.RegisterCLRFieldSetter(field, set_PivotEnd_43);
            app.RegisterCLRFieldBinding(field, CopyToStack_PivotEnd_43, AssignFromStack_PivotEnd_43);
            field = type.GetField("TransState", flag);
            app.RegisterCLRFieldGetter(field, get_TransState_44);
            app.RegisterCLRFieldSetter(field, set_TransState_44);
            app.RegisterCLRFieldBinding(field, CopyToStack_TransState_44, AssignFromStack_TransState_44);
            field = type.GetField("TargetTransTask", flag);
            app.RegisterCLRFieldGetter(field, get_TargetTransTask_45);
            app.RegisterCLRFieldSetter(field, set_TargetTransTask_45);
            app.RegisterCLRFieldBinding(field, CopyToStack_TargetTransTask_45, AssignFromStack_TargetTransTask_45);
            field = type.GetField("LocalPositionState", flag);
            app.RegisterCLRFieldGetter(field, get_LocalPositionState_46);
            app.RegisterCLRFieldSetter(field, set_LocalPositionState_46);
            app.RegisterCLRFieldBinding(field, CopyToStack_LocalPositionState_46, AssignFromStack_LocalPositionState_46);
            field = type.GetField("LocalPositionStart", flag);
            app.RegisterCLRFieldGetter(field, get_LocalPositionStart_47);
            app.RegisterCLRFieldSetter(field, set_LocalPositionStart_47);
            app.RegisterCLRFieldBinding(field, CopyToStack_LocalPositionStart_47, AssignFromStack_LocalPositionStart_47);
            field = type.GetField("LocalPositionEnd", flag);
            app.RegisterCLRFieldGetter(field, get_LocalPositionEnd_48);
            app.RegisterCLRFieldSetter(field, set_LocalPositionEnd_48);
            app.RegisterCLRFieldBinding(field, CopyToStack_LocalPositionEnd_48, AssignFromStack_LocalPositionEnd_48);
            field = type.GetField("ImgState", flag);
            app.RegisterCLRFieldGetter(field, get_ImgState_49);
            app.RegisterCLRFieldSetter(field, set_ImgState_49);
            app.RegisterCLRFieldBinding(field, CopyToStack_ImgState_49, AssignFromStack_ImgState_49);
            field = type.GetField("TargetImgTask", flag);
            app.RegisterCLRFieldGetter(field, get_TargetImgTask_50);
            app.RegisterCLRFieldSetter(field, set_TargetImgTask_50);
            app.RegisterCLRFieldBinding(field, CopyToStack_TargetImgTask_50, AssignFromStack_TargetImgTask_50);
            field = type.GetField("ColorState", flag);
            app.RegisterCLRFieldGetter(field, get_ColorState_51);
            app.RegisterCLRFieldSetter(field, set_ColorState_51);
            app.RegisterCLRFieldBinding(field, CopyToStack_ColorState_51, AssignFromStack_ColorState_51);
            field = type.GetField("ColorStart", flag);
            app.RegisterCLRFieldGetter(field, get_ColorStart_52);
            app.RegisterCLRFieldSetter(field, set_ColorStart_52);
            app.RegisterCLRFieldBinding(field, CopyToStack_ColorStart_52, AssignFromStack_ColorStart_52);
            field = type.GetField("ColorEnd", flag);
            app.RegisterCLRFieldGetter(field, get_ColorEnd_53);
            app.RegisterCLRFieldSetter(field, set_ColorEnd_53);
            app.RegisterCLRFieldBinding(field, CopyToStack_ColorEnd_53, AssignFromStack_ColorEnd_53);
            field = type.GetField("FillAmountState", flag);
            app.RegisterCLRFieldGetter(field, get_FillAmountState_54);
            app.RegisterCLRFieldSetter(field, set_FillAmountState_54);
            app.RegisterCLRFieldBinding(field, CopyToStack_FillAmountState_54, AssignFromStack_FillAmountState_54);
            field = type.GetField("FillAmountStart", flag);
            app.RegisterCLRFieldGetter(field, get_FillAmountStart_55);
            app.RegisterCLRFieldSetter(field, set_FillAmountStart_55);
            app.RegisterCLRFieldBinding(field, CopyToStack_FillAmountStart_55, AssignFromStack_FillAmountStart_55);
            field = type.GetField("FillAmountEnd", flag);
            app.RegisterCLRFieldGetter(field, get_FillAmountEnd_56);
            app.RegisterCLRFieldSetter(field, set_FillAmountEnd_56);
            app.RegisterCLRFieldBinding(field, CopyToStack_FillAmountEnd_56, AssignFromStack_FillAmountEnd_56);
            field = type.GetField("TargetCgTask", flag);
            app.RegisterCLRFieldGetter(field, get_TargetCgTask_57);
            app.RegisterCLRFieldSetter(field, set_TargetCgTask_57);
            app.RegisterCLRFieldBinding(field, CopyToStack_TargetCgTask_57, AssignFromStack_TargetCgTask_57);
            field = type.GetField("AlphaState", flag);
            app.RegisterCLRFieldGetter(field, get_AlphaState_58);
            app.RegisterCLRFieldSetter(field, set_AlphaState_58);
            app.RegisterCLRFieldBinding(field, CopyToStack_AlphaState_58, AssignFromStack_AlphaState_58);
            field = type.GetField("AlphaStart", flag);
            app.RegisterCLRFieldGetter(field, get_AlphaStart_59);
            app.RegisterCLRFieldSetter(field, set_AlphaStart_59);
            app.RegisterCLRFieldBinding(field, CopyToStack_AlphaStart_59, AssignFromStack_AlphaStart_59);
            field = type.GetField("AlphaEnd", flag);
            app.RegisterCLRFieldGetter(field, get_AlphaEnd_60);
            app.RegisterCLRFieldSetter(field, set_AlphaEnd_60);
            app.RegisterCLRFieldBinding(field, CopyToStack_AlphaEnd_60, AssignFromStack_AlphaEnd_60);
            field = type.GetField("TargetCamTask", flag);
            app.RegisterCLRFieldGetter(field, get_TargetCamTask_61);
            app.RegisterCLRFieldSetter(field, set_TargetCamTask_61);
            app.RegisterCLRFieldBinding(field, CopyToStack_TargetCamTask_61, AssignFromStack_TargetCamTask_61);
            field = type.GetField("BackgroundColorState", flag);
            app.RegisterCLRFieldGetter(field, get_BackgroundColorState_62);
            app.RegisterCLRFieldSetter(field, set_BackgroundColorState_62);
            app.RegisterCLRFieldBinding(field, CopyToStack_BackgroundColorState_62, AssignFromStack_BackgroundColorState_62);
            field = type.GetField("BackgroundColorStart", flag);
            app.RegisterCLRFieldGetter(field, get_BackgroundColorStart_63);
            app.RegisterCLRFieldSetter(field, set_BackgroundColorStart_63);
            app.RegisterCLRFieldBinding(field, CopyToStack_BackgroundColorStart_63, AssignFromStack_BackgroundColorStart_63);
            field = type.GetField("BackgroundColorEnd", flag);
            app.RegisterCLRFieldGetter(field, get_BackgroundColorEnd_64);
            app.RegisterCLRFieldSetter(field, set_BackgroundColorEnd_64);
            app.RegisterCLRFieldBinding(field, CopyToStack_BackgroundColorEnd_64, AssignFromStack_BackgroundColorEnd_64);
            field = type.GetField("OrthographicSizeState", flag);
            app.RegisterCLRFieldGetter(field, get_OrthographicSizeState_65);
            app.RegisterCLRFieldSetter(field, set_OrthographicSizeState_65);
            app.RegisterCLRFieldBinding(field, CopyToStack_OrthographicSizeState_65, AssignFromStack_OrthographicSizeState_65);
            field = type.GetField("OrthographicSizeStart", flag);
            app.RegisterCLRFieldGetter(field, get_OrthographicSizeStart_66);
            app.RegisterCLRFieldSetter(field, set_OrthographicSizeStart_66);
            app.RegisterCLRFieldBinding(field, CopyToStack_OrthographicSizeStart_66, AssignFromStack_OrthographicSizeStart_66);
            field = type.GetField("OrthographicSizeEnd", flag);
            app.RegisterCLRFieldGetter(field, get_OrthographicSizeEnd_67);
            app.RegisterCLRFieldSetter(field, set_OrthographicSizeEnd_67);
            app.RegisterCLRFieldBinding(field, CopyToStack_OrthographicSizeEnd_67, AssignFromStack_OrthographicSizeEnd_67);
            field = type.GetField("TargetTextMeshProTask", flag);
            app.RegisterCLRFieldGetter(field, get_TargetTextMeshProTask_68);
            app.RegisterCLRFieldSetter(field, set_TargetTextMeshProTask_68);
            app.RegisterCLRFieldBinding(field, CopyToStack_TargetTextMeshProTask_68, AssignFromStack_TargetTextMeshProTask_68);
            field = type.GetField("TextMeshProColorState", flag);
            app.RegisterCLRFieldGetter(field, get_TextMeshProColorState_69);
            app.RegisterCLRFieldSetter(field, set_TextMeshProColorState_69);
            app.RegisterCLRFieldBinding(field, CopyToStack_TextMeshProColorState_69, AssignFromStack_TextMeshProColorState_69);
            field = type.GetField("TextMeshProColorStart", flag);
            app.RegisterCLRFieldGetter(field, get_TextMeshProColorStart_70);
            app.RegisterCLRFieldSetter(field, set_TextMeshProColorStart_70);
            app.RegisterCLRFieldBinding(field, CopyToStack_TextMeshProColorStart_70, AssignFromStack_TextMeshProColorStart_70);
            field = type.GetField("TextMeshProColorEnd", flag);
            app.RegisterCLRFieldGetter(field, get_TextMeshProColorEnd_71);
            app.RegisterCLRFieldSetter(field, set_TextMeshProColorEnd_71);
            app.RegisterCLRFieldBinding(field, CopyToStack_TextMeshProColorEnd_71, AssignFromStack_TextMeshProColorEnd_71);
            field = type.GetField("MaxVisibleCharactersState", flag);
            app.RegisterCLRFieldGetter(field, get_MaxVisibleCharactersState_72);
            app.RegisterCLRFieldSetter(field, set_MaxVisibleCharactersState_72);
            app.RegisterCLRFieldBinding(field, CopyToStack_MaxVisibleCharactersState_72, AssignFromStack_MaxVisibleCharactersState_72);
            field = type.GetField("MaxVisibleCharactersStart", flag);
            app.RegisterCLRFieldGetter(field, get_MaxVisibleCharactersStart_73);
            app.RegisterCLRFieldSetter(field, set_MaxVisibleCharactersStart_73);
            app.RegisterCLRFieldBinding(field, CopyToStack_MaxVisibleCharactersStart_73, AssignFromStack_MaxVisibleCharactersStart_73);
            field = type.GetField("MaxVisibleCharactersEnd", flag);
            app.RegisterCLRFieldGetter(field, get_MaxVisibleCharactersEnd_74);
            app.RegisterCLRFieldSetter(field, set_MaxVisibleCharactersEnd_74);
            app.RegisterCLRFieldBinding(field, CopyToStack_MaxVisibleCharactersEnd_74, AssignFromStack_MaxVisibleCharactersEnd_74);
            field = type.GetField("EaseFunction", flag);
            app.RegisterCLRFieldGetter(field, get_EaseFunction_75);
            app.RegisterCLRFieldSetter(field, set_EaseFunction_75);
            app.RegisterCLRFieldBinding(field, CopyToStack_EaseFunction_75, AssignFromStack_EaseFunction_75);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.UIFramework.Runtime.Sequence());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.UIFramework.Runtime.Sequence[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Init_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.Sequence instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.Sequence)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Init();

            return __ret;
        }


        static object get_AtTime_0(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AtTime;
        }

        static StackObject* CopyToStack_AtTime_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AtTime;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AtTime_0(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AtTime = (System.String)v;
        }

        static StackObject* AssignFromStack_AtTime_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @AtTime = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AtTime = @AtTime;
            return ptr_of_this_method;
        }

        static object get_StartTime_1(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).StartTime;
        }

        static StackObject* CopyToStack_StartTime_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).StartTime;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_StartTime_1(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).StartTime = (System.Single)v;
        }

        static StackObject* AssignFromStack_StartTime_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @StartTime = *(float*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).StartTime = @StartTime;
            return ptr_of_this_method;
        }

        static object get_TriggerStart_2(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TriggerStart;
        }

        static StackObject* CopyToStack_TriggerStart_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TriggerStart;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_TriggerStart_2(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TriggerStart = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_TriggerStart_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @TriggerStart = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TriggerStart = @TriggerStart;
            return ptr_of_this_method;
        }

        static object get_TriggerEnd_3(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TriggerEnd;
        }

        static StackObject* CopyToStack_TriggerEnd_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TriggerEnd;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_TriggerEnd_3(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TriggerEnd = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_TriggerEnd_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @TriggerEnd = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TriggerEnd = @TriggerEnd;
            return ptr_of_this_method;
        }

        static object get_PropertyRectHeight_4(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PropertyRectHeight;
        }

        static StackObject* CopyToStack_PropertyRectHeight_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PropertyRectHeight;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_PropertyRectHeight_4(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PropertyRectHeight = (System.Single)v;
        }

        static StackObject* AssignFromStack_PropertyRectHeight_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @PropertyRectHeight = *(float*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PropertyRectHeight = @PropertyRectHeight;
            return ptr_of_this_method;
        }

        static object get_PropertyRectY_5(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PropertyRectY;
        }

        static StackObject* CopyToStack_PropertyRectY_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PropertyRectY;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_PropertyRectY_5(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PropertyRectY = (System.Single)v;
        }

        static StackObject* AssignFromStack_PropertyRectY_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @PropertyRectY = *(float*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PropertyRectY = @PropertyRectY;
            return ptr_of_this_method;
        }

        static object get_SequenceType_6(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SequenceType;
        }

        static StackObject* CopyToStack_SequenceType_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SequenceType;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_SequenceType_6(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SequenceType = (Phantom.XRMOD.UIFramework.Runtime.Sequence.Type)v;
        }

        static StackObject* AssignFromStack_SequenceType_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.Type @SequenceType = (Phantom.XRMOD.UIFramework.Runtime.Sequence.Type)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SequenceType = @SequenceType;
            return ptr_of_this_method;
        }

        static object get_EaseType_7(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).EaseType;
        }

        static StackObject* CopyToStack_EaseType_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).EaseType;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_EaseType_7(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).EaseType = (Phantom.XRMOD.UIFramework.Runtime.Ease.Type)v;
        }

        static StackObject* AssignFromStack_EaseType_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Ease.Type @EaseType = (Phantom.XRMOD.UIFramework.Runtime.Ease.Type)typeof(Phantom.XRMOD.UIFramework.Runtime.Ease.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).EaseType = @EaseType;
            return ptr_of_this_method;
        }

        static object get_EasePower_8(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).EasePower;
        }

        static StackObject* CopyToStack_EasePower_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).EasePower;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_EasePower_8(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).EasePower = (Phantom.XRMOD.UIFramework.Runtime.Ease.Power)v;
        }

        static StackObject* AssignFromStack_EasePower_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Ease.Power @EasePower = (Phantom.XRMOD.UIFramework.Runtime.Ease.Power)typeof(Phantom.XRMOD.UIFramework.Runtime.Ease.Power).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).EasePower = @EasePower;
            return ptr_of_this_method;
        }

        static object get_TargetType_9(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetType;
        }

        static StackObject* CopyToStack_TargetType_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetType;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TargetType_9(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetType = (Phantom.XRMOD.UIFramework.Runtime.Sequence.ObjectType)v;
        }

        static StackObject* AssignFromStack_TargetType_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.ObjectType @TargetType = (Phantom.XRMOD.UIFramework.Runtime.Sequence.ObjectType)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.ObjectType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetType = @TargetType;
            return ptr_of_this_method;
        }

        static object get_TargetComp_10(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetComp;
        }

        static StackObject* CopyToStack_TargetComp_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetComp;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TargetComp_10(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetComp = (UnityEngine.Component)v;
        }

        static StackObject* AssignFromStack_TargetComp_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Component @TargetComp = (UnityEngine.Component)typeof(UnityEngine.Component).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetComp = @TargetComp;
            return ptr_of_this_method;
        }

        static object get_Duration_11(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).Duration;
        }

        static StackObject* CopyToStack_Duration_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).Duration;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Duration_11(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).Duration = (System.Single)v;
        }

        static StackObject* AssignFromStack_Duration_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @Duration = *(float*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).Duration = @Duration;
            return ptr_of_this_method;
        }

        static object get_EventDynamic_12(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).EventDynamic;
        }

        static StackObject* CopyToStack_EventDynamic_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).EventDynamic;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_EventDynamic_12(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).EventDynamic = (UnityEngine.Events.UnityEvent<System.Single>)v;
        }

        static StackObject* AssignFromStack_EventDynamic_12(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<System.Single> @EventDynamic = (UnityEngine.Events.UnityEvent<System.Single>)typeof(UnityEngine.Events.UnityEvent<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).EventDynamic = @EventDynamic;
            return ptr_of_this_method;
        }

        static object get_IsUnfolded_13(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).IsUnfolded;
        }

        static StackObject* CopyToStack_IsUnfolded_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).IsUnfolded;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsUnfolded_13(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).IsUnfolded = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsUnfolded_13(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsUnfolded = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).IsUnfolded = @IsUnfolded;
            return ptr_of_this_method;
        }

        static object get_IsDone_14(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).IsDone;
        }

        static StackObject* CopyToStack_IsDone_14(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).IsDone;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsDone_14(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).IsDone = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsDone_14(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsDone = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).IsDone = @IsDone;
            return ptr_of_this_method;
        }

        static object get_Target_15(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).Target;
        }

        static StackObject* CopyToStack_Target_15(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).Target;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Target_15(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).Target = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_Target_15(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @Target = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).Target = @Target;
            return ptr_of_this_method;
        }

        static object get_IsActivating_16(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).IsActivating;
        }

        static StackObject* CopyToStack_IsActivating_16(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).IsActivating;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsActivating_16(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).IsActivating = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsActivating_16(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsActivating = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).IsActivating = @IsActivating;
            return ptr_of_this_method;
        }

        static object get_PlaySFXBy_17(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PlaySFXBy;
        }

        static StackObject* CopyToStack_PlaySFXBy_17(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PlaySFXBy;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PlaySFXBy_17(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PlaySFXBy = (Phantom.XRMOD.UIFramework.Runtime.Sequence.SFXMethod)v;
        }

        static StackObject* AssignFromStack_PlaySFXBy_17(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.SFXMethod @PlaySFXBy = (Phantom.XRMOD.UIFramework.Runtime.Sequence.SFXMethod)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.SFXMethod).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PlaySFXBy = @PlaySFXBy;
            return ptr_of_this_method;
        }

        static object get_SFXFile_18(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SFXFile;
        }

        static StackObject* CopyToStack_SFXFile_18(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SFXFile;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_SFXFile_18(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SFXFile = (UnityEngine.AudioClip)v;
        }

        static StackObject* AssignFromStack_SFXFile_18(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.AudioClip @SFXFile = (UnityEngine.AudioClip)typeof(UnityEngine.AudioClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SFXFile = @SFXFile;
            return ptr_of_this_method;
        }

        static object get_SFXIndex_19(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SFXIndex;
        }

        static StackObject* CopyToStack_SFXIndex_19(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SFXIndex;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_SFXIndex_19(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SFXIndex = (System.Int32)v;
        }

        static StackObject* AssignFromStack_SFXIndex_19(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @SFXIndex = ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SFXIndex = @SFXIndex;
            return ptr_of_this_method;
        }

        static object get_SceneToLoad_20(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SceneToLoad;
        }

        static StackObject* CopyToStack_SceneToLoad_20(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SceneToLoad;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_SceneToLoad_20(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SceneToLoad = (System.String)v;
        }

        static StackObject* AssignFromStack_SceneToLoad_20(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @SceneToLoad = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SceneToLoad = @SceneToLoad;
            return ptr_of_this_method;
        }

        static object get_Event_21(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).Event;
        }

        static StackObject* CopyToStack_Event_21(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).Event;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Event_21(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).Event = (UnityEngine.Events.UnityEvent)v;
        }

        static StackObject* AssignFromStack_Event_21(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent @Event = (UnityEngine.Events.UnityEvent)typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).Event = @Event;
            return ptr_of_this_method;
        }

        static object get_TargetRtTask_22(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetRtTask;
        }

        static StackObject* CopyToStack_TargetRtTask_22(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetRtTask;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TargetRtTask_22(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetRtTask = (Phantom.XRMOD.UIFramework.Runtime.Sequence.RtTask)v;
        }

        static StackObject* AssignFromStack_TargetRtTask_22(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.RtTask @TargetRtTask = (Phantom.XRMOD.UIFramework.Runtime.Sequence.RtTask)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.RtTask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetRtTask = @TargetRtTask;
            return ptr_of_this_method;
        }

        static object get_AnchoredPositionState_23(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchoredPositionState;
        }

        static StackObject* CopyToStack_AnchoredPositionState_23(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchoredPositionState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AnchoredPositionState_23(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchoredPositionState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)v;
        }

        static StackObject* AssignFromStack_AnchoredPositionState_23(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.State @AnchoredPositionState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.State).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchoredPositionState = @AnchoredPositionState;
            return ptr_of_this_method;
        }

        static object get_AnchoredPositionStart_24(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchoredPositionStart;
        }

        static StackObject* CopyToStack_AnchoredPositionStart_24(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchoredPositionStart;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AnchoredPositionStart_24(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchoredPositionStart = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_AnchoredPositionStart_24(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @AnchoredPositionStart = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchoredPositionStart = @AnchoredPositionStart;
            return ptr_of_this_method;
        }

        static object get_AnchoredPositionEnd_25(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchoredPositionEnd;
        }

        static StackObject* CopyToStack_AnchoredPositionEnd_25(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchoredPositionEnd;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AnchoredPositionEnd_25(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchoredPositionEnd = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_AnchoredPositionEnd_25(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @AnchoredPositionEnd = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchoredPositionEnd = @AnchoredPositionEnd;
            return ptr_of_this_method;
        }

        static object get_LocalScaleState_26(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalScaleState;
        }

        static StackObject* CopyToStack_LocalScaleState_26(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalScaleState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LocalScaleState_26(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalScaleState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)v;
        }

        static StackObject* AssignFromStack_LocalScaleState_26(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.State @LocalScaleState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.State).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalScaleState = @LocalScaleState;
            return ptr_of_this_method;
        }

        static object get_LocalScaleStart_27(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalScaleStart;
        }

        static StackObject* CopyToStack_LocalScaleStart_27(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalScaleStart;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LocalScaleStart_27(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalScaleStart = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_LocalScaleStart_27(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @LocalScaleStart = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalScaleStart = @LocalScaleStart;
            return ptr_of_this_method;
        }

        static object get_LocalScaleEnd_28(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalScaleEnd;
        }

        static StackObject* CopyToStack_LocalScaleEnd_28(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalScaleEnd;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LocalScaleEnd_28(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalScaleEnd = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_LocalScaleEnd_28(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @LocalScaleEnd = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalScaleEnd = @LocalScaleEnd;
            return ptr_of_this_method;
        }

        static object get_LocalEulerAnglesState_29(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalEulerAnglesState;
        }

        static StackObject* CopyToStack_LocalEulerAnglesState_29(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalEulerAnglesState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LocalEulerAnglesState_29(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalEulerAnglesState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)v;
        }

        static StackObject* AssignFromStack_LocalEulerAnglesState_29(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.State @LocalEulerAnglesState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.State).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalEulerAnglesState = @LocalEulerAnglesState;
            return ptr_of_this_method;
        }

        static object get_LocalEulerAnglesStart_30(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalEulerAnglesStart;
        }

        static StackObject* CopyToStack_LocalEulerAnglesStart_30(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalEulerAnglesStart;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LocalEulerAnglesStart_30(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalEulerAnglesStart = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_LocalEulerAnglesStart_30(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @LocalEulerAnglesStart = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalEulerAnglesStart = @LocalEulerAnglesStart;
            return ptr_of_this_method;
        }

        static object get_LocalEulerAnglesEnd_31(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalEulerAnglesEnd;
        }

        static StackObject* CopyToStack_LocalEulerAnglesEnd_31(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalEulerAnglesEnd;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LocalEulerAnglesEnd_31(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalEulerAnglesEnd = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_LocalEulerAnglesEnd_31(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @LocalEulerAnglesEnd = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalEulerAnglesEnd = @LocalEulerAnglesEnd;
            return ptr_of_this_method;
        }

        static object get_SizeDeltaState_32(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SizeDeltaState;
        }

        static StackObject* CopyToStack_SizeDeltaState_32(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SizeDeltaState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_SizeDeltaState_32(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SizeDeltaState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)v;
        }

        static StackObject* AssignFromStack_SizeDeltaState_32(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.State @SizeDeltaState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.State).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SizeDeltaState = @SizeDeltaState;
            return ptr_of_this_method;
        }

        static object get_SizeDeltaStart_33(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SizeDeltaStart;
        }

        static StackObject* CopyToStack_SizeDeltaStart_33(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SizeDeltaStart;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_SizeDeltaStart_33(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SizeDeltaStart = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_SizeDeltaStart_33(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @SizeDeltaStart = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SizeDeltaStart = @SizeDeltaStart;
            return ptr_of_this_method;
        }

        static object get_SizeDeltaEnd_34(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SizeDeltaEnd;
        }

        static StackObject* CopyToStack_SizeDeltaEnd_34(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SizeDeltaEnd;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_SizeDeltaEnd_34(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SizeDeltaEnd = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_SizeDeltaEnd_34(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @SizeDeltaEnd = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).SizeDeltaEnd = @SizeDeltaEnd;
            return ptr_of_this_method;
        }

        static object get_AnchorMinState_35(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMinState;
        }

        static StackObject* CopyToStack_AnchorMinState_35(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMinState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AnchorMinState_35(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMinState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)v;
        }

        static StackObject* AssignFromStack_AnchorMinState_35(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.State @AnchorMinState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.State).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMinState = @AnchorMinState;
            return ptr_of_this_method;
        }

        static object get_AnchorMinStart_36(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMinStart;
        }

        static StackObject* CopyToStack_AnchorMinStart_36(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMinStart;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AnchorMinStart_36(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMinStart = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_AnchorMinStart_36(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @AnchorMinStart = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMinStart = @AnchorMinStart;
            return ptr_of_this_method;
        }

        static object get_AnchorMinEnd_37(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMinEnd;
        }

        static StackObject* CopyToStack_AnchorMinEnd_37(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMinEnd;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AnchorMinEnd_37(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMinEnd = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_AnchorMinEnd_37(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @AnchorMinEnd = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMinEnd = @AnchorMinEnd;
            return ptr_of_this_method;
        }

        static object get_AnchorMaxState_38(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMaxState;
        }

        static StackObject* CopyToStack_AnchorMaxState_38(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMaxState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AnchorMaxState_38(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMaxState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)v;
        }

        static StackObject* AssignFromStack_AnchorMaxState_38(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.State @AnchorMaxState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.State).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMaxState = @AnchorMaxState;
            return ptr_of_this_method;
        }

        static object get_AnchorMaxStart_39(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMaxStart;
        }

        static StackObject* CopyToStack_AnchorMaxStart_39(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMaxStart;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AnchorMaxStart_39(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMaxStart = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_AnchorMaxStart_39(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @AnchorMaxStart = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMaxStart = @AnchorMaxStart;
            return ptr_of_this_method;
        }

        static object get_AnchorMaxEnd_40(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMaxEnd;
        }

        static StackObject* CopyToStack_AnchorMaxEnd_40(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMaxEnd;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AnchorMaxEnd_40(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMaxEnd = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_AnchorMaxEnd_40(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @AnchorMaxEnd = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AnchorMaxEnd = @AnchorMaxEnd;
            return ptr_of_this_method;
        }

        static object get_PivotState_41(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PivotState;
        }

        static StackObject* CopyToStack_PivotState_41(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PivotState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PivotState_41(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PivotState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)v;
        }

        static StackObject* AssignFromStack_PivotState_41(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.State @PivotState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.State).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PivotState = @PivotState;
            return ptr_of_this_method;
        }

        static object get_PivotStart_42(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PivotStart;
        }

        static StackObject* CopyToStack_PivotStart_42(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PivotStart;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PivotStart_42(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PivotStart = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_PivotStart_42(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @PivotStart = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PivotStart = @PivotStart;
            return ptr_of_this_method;
        }

        static object get_PivotEnd_43(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PivotEnd;
        }

        static StackObject* CopyToStack_PivotEnd_43(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PivotEnd;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PivotEnd_43(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PivotEnd = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_PivotEnd_43(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @PivotEnd = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).PivotEnd = @PivotEnd;
            return ptr_of_this_method;
        }

        static object get_TransState_44(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TransState;
        }

        static StackObject* CopyToStack_TransState_44(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TransState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TransState_44(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TransState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)v;
        }

        static StackObject* AssignFromStack_TransState_44(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.State @TransState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.State).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TransState = @TransState;
            return ptr_of_this_method;
        }

        static object get_TargetTransTask_45(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetTransTask;
        }

        static StackObject* CopyToStack_TargetTransTask_45(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetTransTask;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TargetTransTask_45(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetTransTask = (Phantom.XRMOD.UIFramework.Runtime.Sequence.TransTask)v;
        }

        static StackObject* AssignFromStack_TargetTransTask_45(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.TransTask @TargetTransTask = (Phantom.XRMOD.UIFramework.Runtime.Sequence.TransTask)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.TransTask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetTransTask = @TargetTransTask;
            return ptr_of_this_method;
        }

        static object get_LocalPositionState_46(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalPositionState;
        }

        static StackObject* CopyToStack_LocalPositionState_46(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalPositionState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LocalPositionState_46(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalPositionState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)v;
        }

        static StackObject* AssignFromStack_LocalPositionState_46(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.State @LocalPositionState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.State).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalPositionState = @LocalPositionState;
            return ptr_of_this_method;
        }

        static object get_LocalPositionStart_47(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalPositionStart;
        }

        static StackObject* CopyToStack_LocalPositionStart_47(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalPositionStart;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LocalPositionStart_47(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalPositionStart = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_LocalPositionStart_47(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @LocalPositionStart = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalPositionStart = @LocalPositionStart;
            return ptr_of_this_method;
        }

        static object get_LocalPositionEnd_48(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalPositionEnd;
        }

        static StackObject* CopyToStack_LocalPositionEnd_48(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalPositionEnd;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LocalPositionEnd_48(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalPositionEnd = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_LocalPositionEnd_48(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @LocalPositionEnd = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).LocalPositionEnd = @LocalPositionEnd;
            return ptr_of_this_method;
        }

        static object get_ImgState_49(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).ImgState;
        }

        static StackObject* CopyToStack_ImgState_49(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).ImgState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ImgState_49(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).ImgState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)v;
        }

        static StackObject* AssignFromStack_ImgState_49(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.State @ImgState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.State).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).ImgState = @ImgState;
            return ptr_of_this_method;
        }

        static object get_TargetImgTask_50(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetImgTask;
        }

        static StackObject* CopyToStack_TargetImgTask_50(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetImgTask;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TargetImgTask_50(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetImgTask = (Phantom.XRMOD.UIFramework.Runtime.Sequence.ImgTask)v;
        }

        static StackObject* AssignFromStack_TargetImgTask_50(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.ImgTask @TargetImgTask = (Phantom.XRMOD.UIFramework.Runtime.Sequence.ImgTask)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.ImgTask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetImgTask = @TargetImgTask;
            return ptr_of_this_method;
        }

        static object get_ColorState_51(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).ColorState;
        }

        static StackObject* CopyToStack_ColorState_51(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).ColorState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ColorState_51(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).ColorState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)v;
        }

        static StackObject* AssignFromStack_ColorState_51(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.State @ColorState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.State).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).ColorState = @ColorState;
            return ptr_of_this_method;
        }

        static object get_ColorStart_52(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).ColorStart;
        }

        static StackObject* CopyToStack_ColorStart_52(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).ColorStart;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ColorStart_52(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).ColorStart = (UnityEngine.Color)v;
        }

        static StackObject* AssignFromStack_ColorStart_52(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Color @ColorStart = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).ColorStart = @ColorStart;
            return ptr_of_this_method;
        }

        static object get_ColorEnd_53(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).ColorEnd;
        }

        static StackObject* CopyToStack_ColorEnd_53(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).ColorEnd;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ColorEnd_53(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).ColorEnd = (UnityEngine.Color)v;
        }

        static StackObject* AssignFromStack_ColorEnd_53(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Color @ColorEnd = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).ColorEnd = @ColorEnd;
            return ptr_of_this_method;
        }

        static object get_FillAmountState_54(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).FillAmountState;
        }

        static StackObject* CopyToStack_FillAmountState_54(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).FillAmountState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_FillAmountState_54(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).FillAmountState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)v;
        }

        static StackObject* AssignFromStack_FillAmountState_54(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.State @FillAmountState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.State).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).FillAmountState = @FillAmountState;
            return ptr_of_this_method;
        }

        static object get_FillAmountStart_55(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).FillAmountStart;
        }

        static StackObject* CopyToStack_FillAmountStart_55(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).FillAmountStart;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_FillAmountStart_55(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).FillAmountStart = (System.Single)v;
        }

        static StackObject* AssignFromStack_FillAmountStart_55(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @FillAmountStart = *(float*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).FillAmountStart = @FillAmountStart;
            return ptr_of_this_method;
        }

        static object get_FillAmountEnd_56(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).FillAmountEnd;
        }

        static StackObject* CopyToStack_FillAmountEnd_56(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).FillAmountEnd;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_FillAmountEnd_56(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).FillAmountEnd = (System.Single)v;
        }

        static StackObject* AssignFromStack_FillAmountEnd_56(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @FillAmountEnd = *(float*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).FillAmountEnd = @FillAmountEnd;
            return ptr_of_this_method;
        }

        static object get_TargetCgTask_57(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetCgTask;
        }

        static StackObject* CopyToStack_TargetCgTask_57(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetCgTask;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TargetCgTask_57(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetCgTask = (Phantom.XRMOD.UIFramework.Runtime.Sequence.CgTask)v;
        }

        static StackObject* AssignFromStack_TargetCgTask_57(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.CgTask @TargetCgTask = (Phantom.XRMOD.UIFramework.Runtime.Sequence.CgTask)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.CgTask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetCgTask = @TargetCgTask;
            return ptr_of_this_method;
        }

        static object get_AlphaState_58(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AlphaState;
        }

        static StackObject* CopyToStack_AlphaState_58(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AlphaState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AlphaState_58(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AlphaState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)v;
        }

        static StackObject* AssignFromStack_AlphaState_58(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.State @AlphaState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.State).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AlphaState = @AlphaState;
            return ptr_of_this_method;
        }

        static object get_AlphaStart_59(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AlphaStart;
        }

        static StackObject* CopyToStack_AlphaStart_59(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AlphaStart;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_AlphaStart_59(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AlphaStart = (System.Single)v;
        }

        static StackObject* AssignFromStack_AlphaStart_59(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @AlphaStart = *(float*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AlphaStart = @AlphaStart;
            return ptr_of_this_method;
        }

        static object get_AlphaEnd_60(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AlphaEnd;
        }

        static StackObject* CopyToStack_AlphaEnd_60(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AlphaEnd;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_AlphaEnd_60(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AlphaEnd = (System.Single)v;
        }

        static StackObject* AssignFromStack_AlphaEnd_60(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @AlphaEnd = *(float*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).AlphaEnd = @AlphaEnd;
            return ptr_of_this_method;
        }

        static object get_TargetCamTask_61(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetCamTask;
        }

        static StackObject* CopyToStack_TargetCamTask_61(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetCamTask;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TargetCamTask_61(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetCamTask = (Phantom.XRMOD.UIFramework.Runtime.Sequence.CamTask)v;
        }

        static StackObject* AssignFromStack_TargetCamTask_61(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.CamTask @TargetCamTask = (Phantom.XRMOD.UIFramework.Runtime.Sequence.CamTask)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.CamTask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetCamTask = @TargetCamTask;
            return ptr_of_this_method;
        }

        static object get_BackgroundColorState_62(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).BackgroundColorState;
        }

        static StackObject* CopyToStack_BackgroundColorState_62(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).BackgroundColorState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_BackgroundColorState_62(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).BackgroundColorState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)v;
        }

        static StackObject* AssignFromStack_BackgroundColorState_62(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.State @BackgroundColorState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.State).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).BackgroundColorState = @BackgroundColorState;
            return ptr_of_this_method;
        }

        static object get_BackgroundColorStart_63(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).BackgroundColorStart;
        }

        static StackObject* CopyToStack_BackgroundColorStart_63(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).BackgroundColorStart;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_BackgroundColorStart_63(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).BackgroundColorStart = (UnityEngine.Color)v;
        }

        static StackObject* AssignFromStack_BackgroundColorStart_63(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Color @BackgroundColorStart = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).BackgroundColorStart = @BackgroundColorStart;
            return ptr_of_this_method;
        }

        static object get_BackgroundColorEnd_64(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).BackgroundColorEnd;
        }

        static StackObject* CopyToStack_BackgroundColorEnd_64(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).BackgroundColorEnd;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_BackgroundColorEnd_64(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).BackgroundColorEnd = (UnityEngine.Color)v;
        }

        static StackObject* AssignFromStack_BackgroundColorEnd_64(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Color @BackgroundColorEnd = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).BackgroundColorEnd = @BackgroundColorEnd;
            return ptr_of_this_method;
        }

        static object get_OrthographicSizeState_65(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).OrthographicSizeState;
        }

        static StackObject* CopyToStack_OrthographicSizeState_65(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).OrthographicSizeState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OrthographicSizeState_65(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).OrthographicSizeState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)v;
        }

        static StackObject* AssignFromStack_OrthographicSizeState_65(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.State @OrthographicSizeState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.State).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).OrthographicSizeState = @OrthographicSizeState;
            return ptr_of_this_method;
        }

        static object get_OrthographicSizeStart_66(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).OrthographicSizeStart;
        }

        static StackObject* CopyToStack_OrthographicSizeStart_66(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).OrthographicSizeStart;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_OrthographicSizeStart_66(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).OrthographicSizeStart = (System.Single)v;
        }

        static StackObject* AssignFromStack_OrthographicSizeStart_66(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @OrthographicSizeStart = *(float*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).OrthographicSizeStart = @OrthographicSizeStart;
            return ptr_of_this_method;
        }

        static object get_OrthographicSizeEnd_67(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).OrthographicSizeEnd;
        }

        static StackObject* CopyToStack_OrthographicSizeEnd_67(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).OrthographicSizeEnd;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_OrthographicSizeEnd_67(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).OrthographicSizeEnd = (System.Single)v;
        }

        static StackObject* AssignFromStack_OrthographicSizeEnd_67(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @OrthographicSizeEnd = *(float*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).OrthographicSizeEnd = @OrthographicSizeEnd;
            return ptr_of_this_method;
        }

        static object get_TargetTextMeshProTask_68(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetTextMeshProTask;
        }

        static StackObject* CopyToStack_TargetTextMeshProTask_68(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetTextMeshProTask;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TargetTextMeshProTask_68(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetTextMeshProTask = (Phantom.XRMOD.UIFramework.Runtime.Sequence.TextMeshProTask)v;
        }

        static StackObject* AssignFromStack_TargetTextMeshProTask_68(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.TextMeshProTask @TargetTextMeshProTask = (Phantom.XRMOD.UIFramework.Runtime.Sequence.TextMeshProTask)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.TextMeshProTask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TargetTextMeshProTask = @TargetTextMeshProTask;
            return ptr_of_this_method;
        }

        static object get_TextMeshProColorState_69(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TextMeshProColorState;
        }

        static StackObject* CopyToStack_TextMeshProColorState_69(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TextMeshProColorState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TextMeshProColorState_69(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TextMeshProColorState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)v;
        }

        static StackObject* AssignFromStack_TextMeshProColorState_69(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.State @TextMeshProColorState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.State).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TextMeshProColorState = @TextMeshProColorState;
            return ptr_of_this_method;
        }

        static object get_TextMeshProColorStart_70(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TextMeshProColorStart;
        }

        static StackObject* CopyToStack_TextMeshProColorStart_70(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TextMeshProColorStart;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TextMeshProColorStart_70(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TextMeshProColorStart = (UnityEngine.Color)v;
        }

        static StackObject* AssignFromStack_TextMeshProColorStart_70(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Color @TextMeshProColorStart = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TextMeshProColorStart = @TextMeshProColorStart;
            return ptr_of_this_method;
        }

        static object get_TextMeshProColorEnd_71(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TextMeshProColorEnd;
        }

        static StackObject* CopyToStack_TextMeshProColorEnd_71(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TextMeshProColorEnd;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TextMeshProColorEnd_71(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TextMeshProColorEnd = (UnityEngine.Color)v;
        }

        static StackObject* AssignFromStack_TextMeshProColorEnd_71(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Color @TextMeshProColorEnd = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).TextMeshProColorEnd = @TextMeshProColorEnd;
            return ptr_of_this_method;
        }

        static object get_MaxVisibleCharactersState_72(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).MaxVisibleCharactersState;
        }

        static StackObject* CopyToStack_MaxVisibleCharactersState_72(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).MaxVisibleCharactersState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_MaxVisibleCharactersState_72(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).MaxVisibleCharactersState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)v;
        }

        static StackObject* AssignFromStack_MaxVisibleCharactersState_72(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Sequence.State @MaxVisibleCharactersState = (Phantom.XRMOD.UIFramework.Runtime.Sequence.State)typeof(Phantom.XRMOD.UIFramework.Runtime.Sequence.State).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).MaxVisibleCharactersState = @MaxVisibleCharactersState;
            return ptr_of_this_method;
        }

        static object get_MaxVisibleCharactersStart_73(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).MaxVisibleCharactersStart;
        }

        static StackObject* CopyToStack_MaxVisibleCharactersStart_73(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).MaxVisibleCharactersStart;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_MaxVisibleCharactersStart_73(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).MaxVisibleCharactersStart = (System.Int32)v;
        }

        static StackObject* AssignFromStack_MaxVisibleCharactersStart_73(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @MaxVisibleCharactersStart = ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).MaxVisibleCharactersStart = @MaxVisibleCharactersStart;
            return ptr_of_this_method;
        }

        static object get_MaxVisibleCharactersEnd_74(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).MaxVisibleCharactersEnd;
        }

        static StackObject* CopyToStack_MaxVisibleCharactersEnd_74(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).MaxVisibleCharactersEnd;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_MaxVisibleCharactersEnd_74(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).MaxVisibleCharactersEnd = (System.Int32)v;
        }

        static StackObject* AssignFromStack_MaxVisibleCharactersEnd_74(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @MaxVisibleCharactersEnd = ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).MaxVisibleCharactersEnd = @MaxVisibleCharactersEnd;
            return ptr_of_this_method;
        }

        static object get_EaseFunction_75(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).EaseFunction;
        }

        static StackObject* CopyToStack_EaseFunction_75(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).EaseFunction;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_EaseFunction_75(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).EaseFunction = (Phantom.XRMOD.UIFramework.Runtime.Ease.Function)v;
        }

        static StackObject* AssignFromStack_EaseFunction_75(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.UIFramework.Runtime.Ease.Function @EaseFunction = (Phantom.XRMOD.UIFramework.Runtime.Ease.Function)typeof(Phantom.XRMOD.UIFramework.Runtime.Ease.Function).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Phantom.XRMOD.UIFramework.Runtime.Sequence)o).EaseFunction = @EaseFunction;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.UIFramework.Runtime.Sequence();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

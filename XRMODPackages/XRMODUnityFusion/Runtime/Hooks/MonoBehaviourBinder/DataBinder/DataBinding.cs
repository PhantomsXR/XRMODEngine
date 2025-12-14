// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Runtime.CodeHook.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Reflection;
using System.Threading.Tasks;
using Phantom.XRMOD.Core.Runtime.Attribute;
using UnityEngine;
using UnityEngine.Assertions;
using UnityFusion.Runtime.Enviorment;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    public class DataBinding : IDataBinder
    {
        private readonly RuntimeFieldHandlerFactory runtimeFieldHandlerFactory = new(new DbAssetProvider());

        public void BindData(MonoData _data)
        {
            if (_data.Fields.Count == 0)
            {
                _data.BoundData = true;
                return;
            }

            // This logic is now self-contained within this method.
            Assert.IsNotNull(_data.ClrInstance, $"CLR Instance on {_data.ClassName} is null.");
            Assert.IsNotNull(_data.ClassType, $"Class Type on {_data.ClassName} is null."); 
 
            foreach (MonoField tmp_MonoField in _data.Fields)
            {
                var tmp_RuntimeTypeHandler = runtimeFieldHandlerFactory.Get(tmp_MonoField.FieldType);
                if (tmp_RuntimeTypeHandler == null || tmp_RuntimeTypeHandler.GetType() == typeof(UnSupportHandler))
                {
                    Debug.LogWarning($"No handler found for field type: {tmp_MonoField.FieldType}");
                    continue;
                }

                var tmp_Data = tmp_RuntimeTypeHandler.ProcessValue(tmp_MonoField, _data, _data.ClassType);
                if (tmp_Data != null && _data.BoundData)
                {
                    MakeSureValue(_data.ClassType, tmp_MonoField, tmp_Data, _data.ClrInstance);
                }
            }
        }

        private void MakeSureValue(Type _type, MonoField _field, object _value,
            CrossBindingAdaptorType _target)
        {
            var tmp_FieldInfo = _type.GetField(_field.FieldName, Utility.CONST_ALL_BINDING_FLAGS);
            if (tmp_FieldInfo != null && _value != null)
            {
                if (_field.FieldType == MonoField.FieldTypeEnum.DataProperty)
                {
                    var tmp_DeserializedDataPropertyMethod = _type.GetMethod(
                        $"DeserializedDataProperty_{_field.FieldName}",
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                    if (tmp_DeserializedDataPropertyMethod == null) return;
                    var tmp_Result =
                        tmp_DeserializedDataPropertyMethod.Invoke(_target.ILInstance, new object[] {_value});
                    var tmp_FieldOfInstance =
                        _type.GetField(_field.FieldName,
                            BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
                    if (tmp_FieldOfInstance == null ||
                        !tmp_FieldOfInstance.IsDefined(typeof(DataPropertyAttribute), true)) return;
                    if (!tmp_FieldOfInstance.IsPublic &&
                        !tmp_FieldOfInstance.IsDefined(typeof(SerializeField), true))
                        return;

                    tmp_FieldOfInstance.SetValue(_target.ILInstance, tmp_Result);
                }
                else
                {
                    MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, _target.ILInstance, _value);
                }
            }
            else
            {
                var tmp_PropertyInfo = _type.GetProperty(_field.FieldName, Utility.CONST_ALL_BINDING_FLAGS);
                if (tmp_PropertyInfo != null)
                {
                    tmp_PropertyInfo.SetValue(_target.ILInstance, _value);
                }
                else
                {
                    string tmp_ClassPath = $"{_target.ILInstance.Type.FullName}";
                    Debug.LogWarning(
                        $"[Convert Error]: Could not find a writable field or property named '{_field.FieldName}' on class '{tmp_ClassPath}'. Data may be lost.");
                }
            }
        }
    }
}
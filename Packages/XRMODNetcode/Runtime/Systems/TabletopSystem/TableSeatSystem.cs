// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the NetCodeTest.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
#if USE_XR
using Unity.XR.CoreUtils;
#endif
using UnityEngine;

namespace Phantom.XRMOD.NetcodeModule.Runtime.TableSystem
{
    public class TableSeatSystem : MonoBehaviour
    {
        private TableTop tableTop;
        public TableTop TableTop => tableTop;

        [SerializeField] private Transform xrOrigin;
        [SerializeField] private float defaultSeatHeight;
        private Action<int> onSeatChanged;

        public void Subscribe(Action<int> _action)
        {
            onSeatChanged += _action;
        }

        public void Unsubscribe(Action<int> _action)
        {
            onSeatChanged -= _action;
        }

        public float DefaultSeatHeight
        {
            get => defaultSeatHeight;
            set => defaultSeatHeight = value;
        }

        private void Awake()
        {
#if USE_XR
            xrOrigin = FindAnyObjectByType<XROrigin>().transform;
#endif
            tableTop = GetComponentInChildren<TableTop>();
            ResetToSeatDefault();
        }

        public void TeleportToSeat(int _seatId)
        {
            if (tableTop.CurrentSeatId < 0)
                tableTop.CurrentSeatId = 0;

            int tmp_PrevSeat = tableTop.CurrentSeatId;
            tableTop.CurrentSeatId = _seatId;

            float tmp_CurrentAngle = GetRotationAngleBasedOnSeatId(tmp_PrevSeat);
            float tmp_NewAngle = GetRotationAngleBasedOnSeatId(_seatId);
            float tmp_RotationAmount = tmp_NewAngle - tmp_CurrentAngle;
            xrOrigin.transform.RotateAround(transform.position, transform.up, tmp_RotationAmount);
            onSeatChanged?.Invoke(_seatId);
            transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);
        }

        public float GetRotationAngleBasedOnSeatId(int _seatId)
        {
            float tmp_Angle = 0;
            switch (_seatId)
            {
                case 1:
                    tmp_Angle = 180;
                    break;
                case 2:
                    tmp_Angle = 270;
                    break;
                case 3:
                    tmp_Angle = 90;
                    break;
            }

            return tmp_Angle;
        }


        internal void ResetToSeatDefault()
        {
            var tmp_CurrentSeat = tableTop.GetSeat(tableTop.CurrentSeatId);
            var tmp_SeatPosition = tmp_CurrentSeat.position;

            tmp_SeatPosition.y -= defaultSeatHeight;
#if USE_XR
            if (xrOrigin == null)
                xrOrigin = FindFirstObjectByType<XROrigin>().transform;
            if (xrOrigin == null)
            {
                return;
            }
#endif
            var tmp_TargetPosition = tmp_SeatPosition - tmp_CurrentSeat.forward * tableTop.SeatOffset;
            var tmp_TargetRotation = tmp_CurrentSeat.rotation;
            xrOrigin.transform.SetPositionAndRotation(tmp_TargetPosition, tmp_TargetRotation);
            tableTop.SeatOffset = 0;
        }
    }
}
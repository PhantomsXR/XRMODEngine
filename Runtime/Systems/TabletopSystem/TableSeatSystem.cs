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
    /// <summary>
    /// Manages the seating logic for a tabletop experience, handling player teleportation and orientation.
    /// </summary>
    public class TableSeatSystem : MonoBehaviour
    {
        private TableTop tableTop;

        /// <summary>
        /// Gets the associated <see cref="TableTop"/> instance.
        /// </summary>
        public TableTop TableTop => tableTop;

        [SerializeField] private Transform xrOrigin;
        [SerializeField] private float defaultSeatHeight;
        private Action<int> onSeatChanged;

        /// <summary>
        /// Subscribes to seat change events.
        /// </summary>
        /// <param name="_action">The action to invoke when the seat changes.</param>
        public void Subscribe(Action<int> _action)
        {
            onSeatChanged += _action;
        }

        /// <summary>
        /// Unsubscribes from seat change events.
        /// </summary>
        /// <param name="_action">The action to remove.</param>
        public void Unsubscribe(Action<int> _action)
        {
            onSeatChanged -= _action;
        }

        /// <summary>
        /// Gets or sets the default height of the seat.
        /// </summary>
        public float DefaultSeatHeight
        {
            get => defaultSeatHeight;
            set => defaultSeatHeight = value;
        }

        private void Awake()
        {
#if USE_XR
            var tmp_Origin = FindAnyObjectByType<XROrigin>();
            if (tmp_Origin != null) xrOrigin = tmp_Origin.transform;
#endif
            tableTop = GetComponentInChildren<TableTop>();
            ResetToSeatDefault();
        }

        /// <summary>
        /// Teleports the player's XR origin to a specific seat.
        /// </summary>
        /// <param name="_seatId">The ID of the seat to teleport to.</param>
        public void TeleportToSeat(int _seatId)
        {
            if (tableTop.CurrentSeatId < 0)
                tableTop.CurrentSeatId = 0;

            int tmp_PrevSeat = tableTop.CurrentSeatId;
            tableTop.CurrentSeatId = _seatId;

            float tmp_CurrentAngle = GetRotationAngleBasedOnSeatId(tmp_PrevSeat);
            float tmp_NewAngle = GetRotationAngleBasedOnSeatId(_seatId);
            float tmp_RotationAmount = tmp_NewAngle - tmp_CurrentAngle;
            
            if (xrOrigin != null)
                xrOrigin.transform.RotateAround(transform.position, transform.up, tmp_RotationAmount);
                
            onSeatChanged?.Invoke(_seatId);
            transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);
        }

        /// <summary>
        /// Calculates the rotation angle (in degrees) based on the seat ID.
        /// </summary>
        /// <param name="_seatId">The seat ID.</param>
        /// <returns>The rotation angle.</returns>
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


        /// <summary>
        /// Resets the player's position and rotation to the default for their current seat.
        /// </summary>
        internal void ResetToSeatDefault()
        {
            if (tableTop == null) return;
            var tmp_CurrentSeat = tableTop.GetSeat(tableTop.CurrentSeatId);
            var tmp_SeatPosition = tmp_CurrentSeat.position;

            tmp_SeatPosition.y -= defaultSeatHeight;
#if USE_XR
            if (xrOrigin == null)
            {
                var tmp_Origin = FindFirstObjectByType<XROrigin>();
                if (tmp_Origin != null) xrOrigin = tmp_Origin.transform;
            }
            if (xrOrigin == null)
            {
                return;
            }
#endif
            var tmp_TargetPosition = tmp_SeatPosition - tmp_CurrentSeat.forward * tableTop.SeatOffset;
            var tmp_TargetRotation = tmp_CurrentSeat.rotation;
            
            if (xrOrigin != null)
                xrOrigin.transform.SetPositionAndRotation(tmp_TargetPosition, tmp_TargetRotation);
                
            tableTop.SeatOffset = 0;
        }
    }
}
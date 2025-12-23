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

using UnityEngine;

namespace Phantom.XRMOD.NetcodeModule.Runtime.TableSystem
{
    /// <summary>
    /// Represents the tabletop and manages the layout of individual seats.
    /// </summary>
    public class TableTop : MonoBehaviour
    {
        /// <summary>
        /// The ID of the seat currently occupied by the local player.
        /// </summary>
        public int CurrentSeatId = -1;

        [SerializeField] TableSeat[] seats;
        
        /// <summary>
        /// Gets the array of seats available at this table.
        /// </summary>
        public TableSeat[] Seats => seats;

        /// <summary>
        /// Gets the standard distance from the center of the table to the seats.
        /// </summary>
        public float SeatDistance => seatDistance;
        [SerializeField] private float seatDistance = .75f;

        [SerializeField] private float seatOffset;

        /// <summary>
        /// Gets or sets an additional positional offset for the seats.
        /// </summary>
        public float SeatOffset
        {
            get => seatOffset;
            set => seatOffset = value;
        }

        /// <summary>
        /// Retrieves the transform of a specific seat.
        /// </summary>
        /// <param name="_seatId">The ID of the seat to retrieve.</param>
        /// <returns>The <see cref="Transform"/> of the seat.</returns>
        public Transform GetSeat(int _seatId)
        {
            return _seatId <= -1 ? seats[0].seatTransform : seats[_seatId].seatTransform;
        }
    }

    /// <summary>
    /// Represents an individual seat at a tabletop.
    /// </summary>
    [System.Serializable]
    public class TableSeat
    {
        /// <summary>
        /// Gets the seat's transform.
        /// </summary>
        public Transform SeatTransform => seatTransform;
        
        /// <summary>
        /// Gets the seat's unique ID.
        /// </summary>
        public int SeatId => seatId;
        
        [SerializeField] internal Transform seatTransform;
        [SerializeField] internal int seatId;
    }
}
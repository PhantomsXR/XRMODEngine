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
    public class TableTop : MonoBehaviour
    {
        public int CurrentSeatId = -1;

        [SerializeField] TableSeat[] seats;
        public TableSeat[] Seats => seats;

        public float SeatDistance => seatDistance;
        [SerializeField] private float seatDistance = .75f;

        [SerializeField] private float seatOffset;

        public float SeatOffset
        {
            get => seatOffset;
            set => seatOffset = value;
        }

        public Transform GetSeat(int _seatId)
        {
            return _seatId <= -1 ? seats[0].seatTransform : seats[_seatId].seatTransform;
        }
    }

    [System.Serializable]
    public class TableSeat
    {
        public Transform SeatTransform => seatTransform;
        public int SeatId => seatId;
        [SerializeField] internal Transform seatTransform;
        [SerializeField] internal int seatId;
    }
}
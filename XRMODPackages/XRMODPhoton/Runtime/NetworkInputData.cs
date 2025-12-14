// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PhotonModule.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/
#if FUSION2
using Fusion;
using UnityEngine;

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    public struct NetworkInputData : INetworkInput
    {
        public const byte MOUSE_LEFT_BUTTON = 0;
        public const byte MOUSE_RIGHT_BUTTON = 1;
        public const byte MOUSE_MID_BUTTON = 2;
        
        public const byte GAMEPAD_NORTH_BUTTON = 3;
        public const byte GAMEPAD_SOUTH_BUTTON = 4;
        public const byte GAMEPAD_EAST_BUTTON = 5;
        public const byte GAMEPAD_WEST_BUTTON = 6;
        
        public const byte GAMEPAD_RIGHT_TRIGGER_BUTTON = 7;
        public const byte GAMEPAD_RIGHT_SHOULDER_BUTTON = 8; 
        public const byte GAMEPAD_Left_TRIGGER_BUTTON = 9;
        public const byte GAMEPAD_Left_SHOULDER_BUTTON = 10; 

        public Vector3 DpadValue;
        public Vector3 LeftJoystickValue;
        public Vector3 RightJoystickValue;
        
        public float RightTrigger;
        public float RightShoulder;
        public float LeftTrigger;
        public float LeftShoulder;

        public bool Option;
        public bool Share;
        public bool LeftJoystickPressed;
        public bool RightJoystickPressed;

        public uint Buttons;

        public bool IsUp(uint _button)
        {
            return IsDown(_button) == false;
        }

        public bool IsDown(uint _button)
        {
            return (Buttons & _button) == _button;
        }

        public bool WasPressed(uint _button, NetworkInputData _oldInput)
        {
            return (_oldInput.Buttons & _button) == 0 && (Buttons & _button) == _button;
        }
    }
}
#endif
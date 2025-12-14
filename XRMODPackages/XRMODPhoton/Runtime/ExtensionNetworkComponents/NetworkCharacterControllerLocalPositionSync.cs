// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Miscellaneous Files.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Fusion;
using UnityEngine;

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    [DisallowMultipleComponent]
    [RequireComponent(typeof(CharacterController))]
    [NetworkBehaviourWeaved(NetworkCCData.WORDS)]
    public class NetworkCharacterControllerLocalPositionSync: NetworkTRSP, INetworkTRSPTeleport, IBeforeAllTicks,
        IAfterAllTicks, IBeforeCopyPreviousState
    {
        new ref NetworkCCData Data => ref ReinterpretState<NetworkCCData>();

        [Header("Character Controller Settings")]
        public float gravity = -20.0f;

        public float jumpImpulse = 8.0f;
        public float acceleration = 10.0f;
        public float braking = 10.0f;
        public float maxSpeed = 2.0f;
        public float rotationSpeed = 15.0f;

        Tick _initial;
        CharacterController _controller;

        public Vector3 Velocity
        {
            get => Data.Velocity;
            set => Data.Velocity = value;
        }

        public bool Grounded
        {
            get => Data.Grounded;
            set => Data.Grounded = value;
        }

        public void Teleport(Vector3? position = null, Quaternion? rotation = null)
        {
            _controller.enabled = false;
            //NetworkTRSP.Teleport(this, transform, position, rotation);
            if (position.HasValue && rotation.HasValue)
            {
                transform.SetLocalPositionAndRotation(position.Value, rotation.Value);
                State.Position = position.Value;
                State.Rotation = rotation.Value;
                ++State.TeleportKey;
            }

            _controller.enabled = true;
        }


        public void Jump(bool ignoreGrounded = false, float? overrideImpulse = null)
        {
            if (Data.Grounded || ignoreGrounded)
            {
                var newVel = Data.Velocity;
                newVel.y += overrideImpulse ?? jumpImpulse;
                Data.Velocity = newVel;
            }
        }

        public void Move(Vector3 direction)
        {
            var deltaTime = Runner.DeltaTime;
            var previousPos = transform.position;
            var moveVelocity = Data.Velocity;

            direction = direction.normalized;

            if (Data.Grounded && moveVelocity.y < 0)
            {
                moveVelocity.y = 0f;
            }

            moveVelocity.y += gravity * Runner.DeltaTime;

            var horizontalVel = default(Vector3);
            horizontalVel.x = moveVelocity.x;
            horizontalVel.z = moveVelocity.z;

            if (direction == default)
            {
                horizontalVel = Vector3.Lerp(horizontalVel, default, braking * deltaTime);
            }
            else
            {
                horizontalVel = Vector3.ClampMagnitude(horizontalVel + direction * acceleration * deltaTime, maxSpeed);
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction),
                    rotationSpeed * Runner.DeltaTime);
            }

            moveVelocity.x = horizontalVel.x;
            moveVelocity.z = horizontalVel.z;

            _controller.Move(moveVelocity * deltaTime);

            Data.Velocity = (transform.position - previousPos) * Runner.TickRate;
            Data.Grounded = _controller.isGrounded;
        }

        public override void Spawned()
        {
            _initial = default;
            TryGetComponent(out _controller);
            // Without disabling and re-enabling the CharacterController here, the first Move call will reset the position to 0,0,0 instead of
            // keeping the position it was spawned at. Presumably disabling it clears some kind of internally cached "previous position" value
            _controller.enabled = false;
            _controller.enabled = true;
            CopyToBuffer();
        }

        public override void Render()
        {
            NetworkTRSP.Render(this, transform, false, false, true, ref _initial);
        }

        void IBeforeAllTicks.BeforeAllTicks(bool resimulation, int tickCount)
        {
            CopyToEngine();
        }

        void IAfterAllTicks.AfterAllTicks(bool resimulation, int tickCount)
        {
            CopyToBuffer();
        }

        void IBeforeCopyPreviousState.BeforeCopyPreviousState()
        {
            CopyToBuffer();
        }

        void Awake()
        {
            TryGetComponent(out _controller);
        }

        void CopyToBuffer()
        {
            Data.TRSPData.Position = transform.localPosition;
            Data.TRSPData.Rotation = transform.localRotation;
        }

        void CopyToEngine()
        {
            // CC must be disabled before resetting the transform state
            _controller.enabled = false;

            // set position and rotation
            transform.SetLocalPositionAndRotation(Data.TRSPData.Position, Data.TRSPData.Rotation);

            // Re-enable CC
            _controller.enabled = true;
        }
    }
}
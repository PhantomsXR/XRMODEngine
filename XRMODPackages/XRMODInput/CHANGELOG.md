# 1.4.9
## Updated
- Update commit and docs
# 1.4.8

## Fixed

- Fixed Spatial keyboard asset ref

# 1.4.7

## Fixed

- Fixed Spatial keyboard asset ref

# 1.4.6

## Fixed

- Add XRMOD_INSTALL Constraints

# 1.4.5

## Fixed

- Fixed Spatial keyboard shader missing
- Fixed Spatial keyboard xr grabber

# 1.4.4

## Added

- Added XRPokeFollowAffordance
- Added Spatial Keyboard

# 1.4.3

## Update

- Update XR Hand version

# 1.4.2

## Added

- Added XRIHoverFilter, XRISelectFilter
- Added XRI UnityFusion CLRs

# 1.4.1

## Fixed

- Fixed XRGeneralSettings not found when build at visionOS platform.

# 1.4.0

## Changed

- Optimize project structure

# 1.3.9

## Changed

- Remove excess Clrs to avoid large performance losses

# 1.3.8

## Added

- Added Missing CLRs

# 1.3.7

## Changed

- Now XR Controller Animation script support custom input device model and Reversal input value;
  .

# 1.3.6

## Changed

- Changed spaceType to realtime

# 1.3.5

## Fixed

- Fixed not xr origin error
- Fixed GetCurrentInputType error when not XR Camera in scene

# 1.3.4

## Fixed

- Fixed Rokid platform GetCurrentInputType is unknow type

# 1.3.3

## Fixed

- Fixed Action not found for XRController

## Changed

- Changed GetXRControllerPose method name to TryGetXRControllerPose

# 1.3.2

## Added

- Added GetXRControllerPose method

# 1.3.1

## Added

- Added Custom gestures support
- Added TryGetXRControllerButtonInput/TryGetXRControllerAxis methods

## Removed

- Removed IsGrip method

# 1.3.0

## Added

- Added Grab checking for XRController and hand
- Added TryGetPinch for each hand

# 1.2.0

## Added

- Added XRBaseGrabTransform component

# 1.1.1

## Fixed

- Fixed incorrect hand's far cast state when call UniversalXRInput.GetInstance.SetInteractor()

# 1.1.0

## Added

- Added **XRMOD_INSTALL** Define Constraints

# 1.1.0

## Added

- Added support **hands** and **controller** rayinteractor
- Added **InteractorHandness** to distinguish left and right controllers or left and right hands.
- Added **EnhancedTouchSupport** for Classic 3d
- Added **GetCurrentInputType** method to check current input type
- Added **Handness dictionary**

## Fixed

- Fixed UniversalXRInput create instanced repeat error

## Changed

- Changed **InteractorType** to **InteractorMode**
- Changed GetRayInteractorPose(out Vector3 _position, out Quaternion _rotation) to GetRayInteractorPose(
  InteractorHandness _handedness, out Vector3 _position,
  out Quaternion _rotation)
- Changed GetRayInteractor(out NearFarInteractor _nearFarInteractor) to GetRayInteractor(InteractorHandness _handness,
  out NearFarInteractor _nearFarInteractor)

## Removed

- Removed **IsInputDeviceCharacteristics** method

# 1.0.15

## Added

- Add DynamicMoveProvider
- Add ControllerInputActionManager
- Add JointVisualizer
- Add **IsInputDeviceCharacteristics** method
- Add XRMOD_INSTALL to defineconstraints

## Improved

- Improving the **InputType** key in difference platform

# 1.0.14

## Fix

- Fix destroy hands aggregator game object error

# 1.0.13

## Fix

- Fix metal space hand tracking

# 1.0.12

## Add

- Add TryGetJointTransform API

## Change

- Change TryGetJoint to TryGetJointPose

## Fix

- Error Unity Cannot find Delegate Adapter for:UnityEngine.InputSystem.EnhancedTouch.Finger _finger
- Fix Vibration error in visionOS

# 1.0.11

## Fix

- Fix HandsAggregatorSubsystem gameobject not destroy issue

# 1.0.10

## Added

- Add New input system clr types

# 1.0.9

## Added

- Add VibrateAndroidDeviceOnly(int _cancelMilliseconds)

# 1.0.8

## Added

- Add Haptic Component
- Auto initialized of Vibration

## Fix

- Fix Rokid Platform Haptic

# 1.0.7

## Fix

- Fix correct XRI dependency

# 1.0.6

## Added

- [Haptic]: Add Vibration(Android/iOS)

## Improved

- Organize folders

# 1.0.5

# 1.0.4

## Improved

- Register XRI,Hand,NewInputSystem clrs

## Added

- Add `GetRayInteractorPose` and `GetRayInteractor` Apis(Only Rokid AR Lite).

# 1.0.2

## Fixed

- Fix incorrect hand join pose to world pose.

## Added

- Add `SetupInteractorState` api, you can set near or far interactor via script
  now.[CHANGELOG.md](..%2F..%2F..%2FUnity6000%2FSources%2FXRMODInput%2FCHANGELOG.md)[CHANGELOG.md](CHANGELOG.md)
- Add `OnLeftHandTrackingLost`,`OnRightHandTrackingLost`,`OnLeftHandTracked`,`OnRightHandTracked` event for *
  *HandVisualizer.cs**. It is used to manage the hand state to prevent the hand from being lost. Far/Near interactors
  are still displayed.

## Change

- Change **ILCode** folder to **UnityFusion**
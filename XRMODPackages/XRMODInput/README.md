# XRMODInput Module

The **XRMODInput** module is a core component of the XRMOD Engine, designed to provide a unified, platform-agnostic API for handling user input across various XR devices. It abstracts the complexities of different input modalities—such as hand tracking, specialized XR controllers, gaze, and traditional peripherals—into a consistent and easy-to-use interface.

## 🚀 Key Features

- **Unified API**: Access hand tracking and controller data through a single entry point (`UniversalXRInput`).
- **Platform Agnostic**: Supports Unity XR Interaction Toolkit (XRI), OpenXR, and vendor-specific SDKs (Meta Quest, PICO, Rokid, etc.).
- **Modality Switching**: Seamlessly switch between hand tracking and controller input at runtime.
- **Haptic Feedback**: Robust cross-platform vibration system for iOS and Android.
- **Gaze Interaction**: Built-in eye-tracking and head-tracking fallback logic.
- **Locomotion Mediation**: Advanced management of locomotion states (teleport vs. smooth movement) to prevent input conflicts.

## 📦 Module Structure

- **Common**: Contains the core `UniversalXRInput` class and logic for hand/controller data retrieval.
- **Vibration**: Cross-platform haptic feedback utilities.
- **XRI**: Integration with Unity's XR Interaction Toolkit, including gaze management and controller orchestration.
- **Enums**: Shared definitions for input types, interactor modes, and controller keys.

## 🛠 Getting Started

### Accessing Input
The main entry point for the module is the `UniversalXRInput` singleton.

```csharp
using Phantom.XRMOD.XRMODInput.Runtime;

// Get the current input modality
InputType currentType = UniversalXRInput.GetInstance.GetCurrentInputType();

if (currentType == InputType.NatureHands) {
    // Handle hand tracking logic
}
```

### Hand Tracking
Retrieve joint poses or pinch status easily:

```csharp
if (UniversalXRInput.GetInstance.TryGetPinch(Handedness.Right)) {
    Debug.Log("Right hand pinching!");
}

// Get the pose of the palm in world space
if (UniversalXRInput.GetInstance.TryGetJointPose(XRHandJointID.Palm, XRNode.LeftHand, out Pose palmPose, true)) {
    Debug.Log($"Palm position: {palmPose.position}");
}
```

### Haptic Feedback
Trigger vibrations on mobile devices:

```csharp
using Phantom.XRMOD.XRMODInput.Runtime;

// Trigger a soft impact haptic on iOS
Vibration.VibrateIOS(ImpactFeedbackStyle.Soft);

// Trigger a short vibration on Android
Vibration.VibrateAndroid(50);
```

### Gaze Interaction
The `GazeInputManager` automatically handles fallback when eye tracking is unavailable:

```csharp
// Enable or disable head-tracking fallback
gazeManager.FallbackIfEyeTrackingUnavailable = true;
```

## 💡 Best Practices

1. **Use UniversalXRInput**: Avoid using legacy `UniversalInput` or platform-specific APIs directly.
2. **Check Modality**: Always verify the current `InputType` before performing modality-specific operations.
3. **Handle Shared Space**: Be aware that certain features (like detailed pinch progress) may only be supported in `FullSpace` modes.
4. **Locomotion Safety**: Use `ActionBasedControllerManager` to mediate between teleportation and smooth movement to avoid confusing the user.

## ⚠️ Common Pitfalls

- **Missing XRI**: Ensure `USE_XRI` is defined in your project settings if you are using the XRI-based features.
- **Handedness Mismatch**: Double-check `XRNode.LeftHand` vs `XRNode.RightHand` when querying joint data.
- **Android Vibrations**: Remember that Android vibrations require the `VIBRATE` permission in the Manifest.
- **Obsolete APIs**: Do not use `UniversalInput`; it is kept for backward compatibility but marked as obsolete.

---
*Developed by PhantomsXR Ltd.*


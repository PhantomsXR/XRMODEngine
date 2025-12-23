# XR-MOD Quest Module

## Overview

The **XR-MOD Quest Module** provides dedicated support for Meta Quest devices within the XR-MOD ecosystem. It integrates Meta's OpenXR features—such as Passthrough, Scene Capture, Meshing, and Occlusion—directly into the XR-MOD architecture to enable rich Mixed Reality experiences.

This module is designed to "plug and play": it automatically registers itself when running on a Quest device and manages the lifecycle of Quest-specific features based on your runtime experience configuration.

## Key Features

*   **Mixed Reality (Passthrough)**
    *   Seamlessly toggle local context passthrough to blend virtual content with the real world.
    *   Controls camera background and clear flags automatically.

*   **Scene Understanding & Meshing**
    *   **Meshing**: Generate physics meshes from the environment for collisions and navigation.
    *   **Scene Capture**: Integration with Meta's Scene Capture (Spatial Setup) to let users define their room layout.
    *   **Bounding Boxes**: Access and visualize semantic scene data (walls, tables, couches).

*   **Advanced Occlusion**
    *   Support for Environment Depth.
    *   Dynamic **Hand Removal** from the depth map.
    *   **Temporal Smoothing** for stable occlusion edges.
    *   Configurable alignment with Human Segmentation.

*   **Input & Interaction**
    *   **Smart Switching**: Automatically switches visualizers and interactors between Controllers and Hand Tracking based on user activity.
    *   **Locomotion**: Integrated support for Teleportation, Continuous Turn, and Joystick Movement.
    *   **Visualizers**: Automatic management of controller and hand meshes.

*   **Passthrough Camera Access** (Requires Horizon OS v74+)
    *   Low-level access to passthrough camera frames via `WebCamTexture`.
    *   Utilities to query camera intrinsics, poses, and capabilities.

## Usage & Configuration

The module is driven by the **XR-MOD Runtime Experience Config**. You do not typically need to write code to enable standard features; instead, you configure them in your project settings or incoming data stream.

### Configuration Model (`XRConfiguresModel`)

The module attempts to resolve `XRConfiguresModel` from the global `RuntimeExperienceConfig`. Key properties include:

| Property | Description |
| :--- | :--- |
| `UseOcclusion` | Master switch to enable/disable occlusion. |
| `EnableHandRemoval` | If true, hands are masked out of the occlusion buffer (prevents self-occlusion artifacts). |
| `TemporalSmoothing` | Enables time-based smoothing for depth data. |
| `EnvironmentDepthMode` | Sets the precision (e.g., Medium, High) of environment depth. |
| `CustomMeshVisualizerName` | Name of a prefab in your package to use for visualizing the environment mesh. |

### Scene Capture
To trigger the Scene Capture (Room Setup) flow on the device, send a notification:
```csharp
ActionNotificationCenter.DefaultCenter.PostNotification("CaptureEnvironment", null);
```

## Architecture

The module follows the **Interceptor/Decorator** pattern common in XR-MOD:

1.  **Registry**: `AutoRegisterModule.cs` detects the Quest platform at startup and registers `MetaQuestModule` into the IoC container.
2.  **Module**: `MetaQuestModule` acts as the controller. It listens for configuration updates and builds/activates specific **Feature Decorators**.
3.  **Decorators**: Small, focused classes (e.g., `MetaQuestMeshingDecorator`, `MetaQuestLocomotionFeatureDecorator`) that wrap specific subsystems (like `ARMeshManager` or `AROcclusionManager`) and manage their lifecycle.
4.  **Components Model**: `ArchitectureComponentsModel` is a singleton that caches references to the specific XR hardware, such as the `XRRig`, `ARCamera`, and `LocomotionSystem`, to ensure features can easily find what they need to manipulate.

## API Overview

### Core
*   **`MetaQuestModule`**: The main entry point. Manages dependencies and orchestration.
*   **`XRRuntimeContextDataModel`**: Holds volatile runtime state, such as AR Session status, frame textures, and recognized markers.

### Passthrough Camera (Advanced)
Located in `Phantom.XRMOD.QuestModule.Runtime.PassthroughCamera`:
*   **`PassthroughCameraUtils`**: Helpers for retrieving camera intrinsics and world poses.
*   **`WebCamTextureManager`**: A component to manage the lifecycle of a `WebCamTexture` for a specific eye (Left/Right).
*   **`PassthroughCameraPermissions`**: Handles the Android permission requests (`android.permission.CAMERA` and `horizonos.permission.HEADSET_CAMERA`).

## Pitfalls & Best Practices

*   **Platform Checks**: This module is wrapped in `#if QUEST_INSTALL`. Ensure your code calling it also respects platform defines or uses the provided Abstractions/Interfaces to avoid build errors on other platforms.
*   **Permissions**: Passthrough Camera access requires explicit user permission. The `PassthroughCameraPermissions` script handles this, but your app must gracefully handle cases where permission is denied.
*   **OS Version**: Raw Passthrough Camera access is only available on Quest devices running **Horizon OS v74 or later**.
*   **Occlusion Performance**: Enabling High-Res Depth and Temporal Smoothing can be expensive. Profile your application performance when these are enabled.

## Dependencies

*   `Phantom.XRMOD.Core`
*   `Phantom.XRMOD.ActionNotification`
*   Unity `ARFoundation`
*   Unity `OneXR` / `Meta OpenXR Feature` group

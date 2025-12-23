# XRMODOpenXR Module

The `XRMODOpenXR` module provides advanced OpenXR features and utilities for the XRMOD Engine, specifically optimized for Meta Quest and Android XR platforms. It includes specialized systems for boundary visibility management, system permission handling, and Application SpaceWarp (ASW).

## Key Features

- **Boundary Visibility Control**: Programmatically suppress or restore the Meta OpenXR boundary visibility.
- **Unified Permission Management**: Handle Android system permissions (like Scene Understanding) across different XR platforms.
- **Application SpaceWarp (ASW)**: Integrate Meta's SpaceWarp technology to maintain high visual quality at reduced frame rates.
- **Platform Understanding**: Runtime detection of the active OpenXR runtime (Meta, Android XR, etc.).

## Installation

This module is typically included as part of the XRMOD Engine packages. Ensure that the `Unity OpenXR` and `Meta OpenXR` features are installed and enabled in your project settings if targeting Quest.

## Core Components

### 1. OpenXRBoundaryVisibilitySystem
Allows for controlling the visibility of the safety boundary on supported platforms.

**Usage Example:**
```csharp
using Phantom.XRMOD.OpenXRMOD.Runtime;

// Suppress the boundary visibility
OpenXRBoundaryVisibilitySystem.ChangeBoundaryVisibility(XrBoundaryVisibility.VisibilitySuppressed);

// Restore the boundary visibility
OpenXRBoundaryVisibilitySystem.ChangeBoundaryVisibility(XrBoundaryVisibility.VisibilityNotSuppressed);
```

**Notes:**
- Primarily supports Meta Quest via the `XR_FB_boundary_visibility` extension.
- Suppression might be ignored by the system if safety protocols require the boundary to be visible.

### 2. OpenXRPermissionManager
Simplifies requesting Android permissions required for advanced XR features like Scene Reconstruction.

**Usage Example:**
```csharp
using Phantom.XRMOD.OpenXRMOD.Runtime;

public class MyPermissionHandler : MonoBehaviour {
    [SerializeField] private OpenXRPermissionManager permissionManager;

    void Start() {
        permissionManager.OnPermissionGrantedHandler += (permissionId) => {
            Debug.Log($"Permission {permissionId} granted!");
        };
        permissionManager.ProcessPermissions();
    }
}
```

### 3. SpacewarpController
Manages Application SpaceWarp to help apps achieve higher apparent frame rates.

**Usage Example:**
```csharp
using Phantom.XRMOD.OpenXRMOD.Runtime;

// Enable Spacewarp
SpacewarpController.Instance.SetSpacewarpEnabled(true);
```

**Pitfalls:**
- When SpaceWarp is enabled, you MUST ensure that the SpaceWarp transform is updated every frame. The `SpacewarpController` handles this automatically via its `Update` method using its own transform.

## Platform Detection
Use `XRPlatformUnderstanding` to write platform-specific code.

```csharp
if (XRPlatformUnderstanding.CurrentPlatform == XRPlatformType.Quest) {
    // Quest specific logic
}
```

## Troubleshooting & Pitfalls

- **Permissions**: Always check if the permission is granted before calling APIs that depend on it. `OpenXRPermissionManager` handles the boilerplate but logic should be defensive.
- **SpaceWarp Shaders**: SpaceWarp requires motion vectors. Ensure your materials and shaders support motion vector generation if using custom shaders.
- **Boundary Suppression**: Excessive suppression of the boundary can lead to safety issues and might cause your app to be rejected from stores if not used judiciously.

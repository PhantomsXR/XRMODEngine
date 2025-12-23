# XRMOD UI Framework

The **XRMOD UI Framework** is a comprehensive toolkit designed to help developers inspect, prototype, and build high-quality user interfaces for XR experiences with a unified, premium aesthetic (inspired by VisionOS glassmorphism).

It combines a rich library of pre-styled widgets with a robust, inspector-driven animation system to dramatically reduce the time needed to create dynamic and responsive UI.

## Key Features

### 🎨 VisionOS-Style Design System
A complete set of "Glass" styled UI components that look premium out of the box. Includes:
*   **Polished Widgets**: Buttons, Sliders, Toggles, Input Fields, and Checkboxes with high-quality blur, glow, and shadow assets.
*   **Windowing System**: "Glass" windows with automatic background blurring and standard overlays.
*   **Typography**: Pre-configured TextMeshPro setups for hierarchy (Semibold, Regular, etc.).

### 🎬 AnimationUI System
A powerful, code-optional animation engine designed specifically for UI.
*   **Sequence-Based**: Create complex animation chains (Parallel or Sequential) directly in the Unity Inspector.
*   **Rich Target Support**: Animate `RectTransform` (Position, Scale, SizeDelta), `CanvasGroup` (Fade), `Image` (Color, Fill), `Text` (Typewriter effect), and more.
*   **Easing Library**: Built-in support for all standard easing functions (Bounce, Elastic, Quart, etc.).
*   **Event Triggering**: Fire Unity Events or C# Actions at specific times within an animation sequence.

### 🧩 Advanced Components
*   **Infinite Scroll**: Performant re-usable list views for large datasets.
*   **Window Stacker**: Manages depth and focus for multiple overlapping UI windows.
*   **Independent Rounded Corners**: `Image` components that allow different radius values for each corner.
*   **UI Particles**: Integration to render particle systems correctly within the UI Canvas sorting order.

## Usage

### Creating Elements
The framework integrates directly into the Unity Editor GameObject menu.
1.  Right-click in the **Hierarchy** or select **GameObject** in the top menu.
2.  Navigate to **XRMOD > UI Framework**.
3.  Choose from categories like **Buttons**, **Sliders**, **Windows**, etc.
4.  The element will be created with all necessary components, blocks, and animations pre-configured.

### Using AnimationUI
To add animations to any object:
1.  Add the `AnimationUI` component to your GameObject.
2.  In the Inspector, expand **Animation Sequence**.
3.  Add a new **Sequence** item.
4.  Select a **Target** (e.g., the GameObject itself) and a **Type** (e.g., `RectTransform`).
5.  Choose the property to animate (e.g., `AnchoredPosition`) and set the **Start/End** values and **Duration**.
6.  Call `Play()` from script or check **Play On Start**.

### Runtime Implementation
While primarily designed for Editor-time assembly, you can use the `VisionControls` static class to generate these complex UI prefabs strictly from code at runtime:

```csharp
// Example: Creating a Text Button via code
var buttonGO = VisionControls.CreateTextButton(resources, 200, 60, 24);
```

## Structure
*   **Runtime/AnimationUI**: Core logic for the animation sequencing system.
*   **Runtime/Widgets**: Component logic for Buttons, Sliders, and visual elements.
*   **Runtime/Shaders**: Custom shaders for UI blur, glow, and rounding effects.
*   **Editor**: Custom inspectors and menu integration logic.

## Requirements
*   **TextMeshPro**: Used for all text rendering.
*   **Unity UI (UGUI)**: The underlying UI system.

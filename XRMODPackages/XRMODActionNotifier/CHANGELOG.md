# 2.0.6

## Removed

- Removed InvalidCref

# 2.0.5

## Updated

- Update commit and docs

# 2.0.4

## Fixed

- Fixed frequent and fast AddObserver and Remove Observer that could not be executed correctly by Post

# 2.0.3

## Added

- Added ProcessMonoBinderBatch keyword

# 2.0.2

## Changed

- Improved performance

# 2.0.1

## Changed

- Optimize the project

# 2.0.0

- Release

# 2.0.0-pre.16

## Added

- Added PostNotificationAsync and AddAsyncObserver

# 2.0.0-pre.15

## Changed

- Change some AR ARAlgorithmType to specify platform

# 2.0.0-pre.14

## Added

- Add PassThrough key for ARAlgorithmArgs
- Add ARBoundingBoxArgs

# 2.0.0-pre.13

## Added

- Add new ActionParameterDataType key[**ProcessMonoBinder**], it will use to trigger the bind MonoBinder action.

# 2.0.0-pre.8

## Added

- Add new action type `LoadRuntimeScene`
- Add new action type `ForceLightingBakeApply`

# 2.0.0-pre.4

## Added

- Add new action type `ReleaseProject`

# 2.0.0-pre.3

## Add

- Add new action type `SendMessageToSDK`,`LoadARWordMap`,`SaveARWordMap`,

# 2.0.0-pre.2

## Add

- Add two new algorithms to `ARAlgorithmNotificationData`. Now developer can control the `ARBackground` and `Basic` AR
  module status

# 1.0.0-alpha.2

## Change

- Fix InvalidOperationException: Collection was modified; enumeration operation may not execute.

# 1.0.0-alpha.1

## Change

- Add new commit
- Adapter to C# 8

# 0.0.4-alpha.1

## Change

Update version number to 0.0.4-alpha.1

# 0.0.3-preview.1

## Fix

- Call error again after releasing the ActionNotificationCenter
- Fix the invoke error when add observer. remove `Foreach` loop. `For` instead.

## Add

- Add `Release` method to free singleton
- Add new class `TryAcquireCurrentFrameNotificationData`. Let developer custom acquire the specify texture format.
- Add `ResizeARWorldScale` notification data
- Add new enum parameter `ResizeARWorldScale`

## Change

- `ActionNotificationCenter` no longer inherits `MonoBehaviour`
- Remove `ANN` Editor menu

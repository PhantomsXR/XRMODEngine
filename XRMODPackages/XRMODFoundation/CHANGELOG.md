# 3.0.13
## Updated
- Update commit and docs
# 3.0.12

## Removed

- **SDKEntry**: Removed SupabaseLibs

## Added

- **SDKEntry**: Added Supabase request via Unity webrequest

# 3.0.11

## Improved

- **SetupEditor**: Implemented "UI Caching" and "Staggered Execution" for drawers to eliminate UI lag and reduce "
  Semaphore.Wait" spikes.
- **SetupEditor**: Added automated fix for Input System "Active Input Handling" (auto-sets to 'Both' and prompts for
  restart).
- **SetupEditor**: Optimized `RebuildDrawers` to reuse cached UI elements instead of rebuilding, significantly improving
  refresh performance.

## Fixed

- **SetupEditor**: Fixed memory leaks in `ShadersValidationDrawer` and `XRMODEnginePreferences` by properly disposing
  `SerializedObject`.
- **SetupEditor**: Fixed compilation errors (`CS0103`, `CS1503`) and scoping issues in strict compilation environments.
- **SetupEditor**: Fixed "Input System" fix logic where the UI wouldn't update immediately after fixing.

# 3.0.10

## Fixed

- **PackageTools**: Fixed UI Toolkit uss missing at NewProjectWizard.uxml
- **PackageTools**: Fixede OnGUI error at UnityEditor.EditorApplication:Internal_CallUpdateFunctions

# 3.0.9

## Fixed

- **PackageTools**: Fixed dependency package of Script build pipline

# 3.0.8

## Added

- **PackageTools**: Compatible with Multiplayer Play Mode 2.0

# 3.0.7

## Added

- Added Shader vairant collector tool

## Improved

- Improved Experience inspector

## Removed

- Removed MeshSerializer
- Removed Curve To AnimationClip

# 3.0.6

## Improved

- **PackageTools**: Add `UnityFusionEventBus` and `UnityFusionSingletonTemplate` to project

# 3.0.5

## Improved

- **PackageTools**: support internal drag-and-drop operations.

# 3.0.4

## Improved

- **PackageTools**: Migrate legacy PackageTools data where group and assets were mixed in contents to the new structure
  where group is separate and contains assets.

# 3.0.3

## Added

- Added Supabase SDK
- Added new packages:
    - Added API
    - Added Utilities
    - Added PackageTools
    - Added Setup
    - Added Rendering
    - Added Localization
    - Added AudioModule

# 2.0.0-preview.64

## Fixed

- Fixed RegisterInstance error

# 2.0.0-preview.63

## Changed

- Increase readability of InjectorCache GetOrBuild method

# 2.0.0-preview.62

## Fixed

- Fixed an error when injecting data into GameObject with multiple Monobeaviours

# 2.0.0-preview.61

## Fixed

- Fixed Inject and InjectToGameObject GC

# 2.0.0-preview.60

## Fixed

- Fixed VContainer RegisterInstance not work on UnityFusion

# 2.0.0-preview.59

## Added

- Added VContainer DI framework into XR-MOD Engine

# 2.0.0-preview.58

## Changed

- **XRMOD Core**: Remove OnInstanced method from SingletonTemplate

# 2.0.0-preview.57

## Added

- **XRMOD Core**: Added 'DontConvertToMonoBinderAttribute'
- **XRMOD Core**: Added 'MonoBehaviourSingleton<T>' template

## Removed

- **XRMOD Core**: Removed XRMODCore Empty UnityFusion

# 2.0.0-preview.56

## Added

- Added `UpdateBatchOptimization`

# 2.0.0-preview.55

## Fixed

- Fixed an object is allocated in managed memory(BuildProcessesManagerCommand).

# 2.0.0-preview.54

## Changed

- Set XRMOD_INSTALL define to asmdef

# 2.0.0-preview.53

## Changed

- Optimize the project

# 2.0.0-preview.53

## Added

- Added Missing CLRs

# 2.0.0-preview.52

## Added

- Added ReleaseAssetBundleScene

# 2.0.0-preview.51

## Fixed

- Fixed Release project not cleanup all asset and code

# 2.0.0-preview.50

## Fixed

- Fixed load,progress and completed callbacks not working when load pack mode experience

# 2.0.0-preview.49

## Changed

- Changed dlls to source code

# 2.0.0-preview.48

## Fixed

- Fixed package build crc and hash not changed on pack mode

# 2.0.0-preview.47

## Added

- Added CustomDataPropertyAttribute

# 2.0.0-preview.46

## Fixed

- Fixed Key not found after multiple project loaded error

# 2.0.0-preview.45

## Removed

- Removed XRMOD_INSTALL Define Constraints from XRMOD.Core DLL

# 2.0.0-preview.44

## Added

- Added **XRMOD_INSTALL** Define Constraints

# 2.0.0-preview.43

## Fixed

- Fixed Meta Quest Simulator fetch bug
- Fixed Meta Quest platform simulator fetch url

## Removed

- Removed SDKInformation file

## Added

- Add APICallback.ProcessesChanged when Process add or release

# 2.0.0-preview.42

## Fixed

- Fixed Meta Quest Simulator fetch bug

## Removed

- Removed SDKInformation file

# 2.0.0-preview.41

## Fixed

- Fixed Scene lighting

# 2.0.0-preview.40

## Added

- Added SDKInformation
- Added XRMOD_INSTALL to define constraints

# 2.0.0-preview.39

## Fixed

- Fixed load package from url

## Improved

- Improved package download speed

# 2.0.0-preview.38

## Added

- Added LoadScene support.
- Added Load package support.

# 2.0.0-preview.37

## Update

- Update Unity 6000 Foundation Libs to newly

# 2.0.0-preview.36

## Changed

- Removed UnityFusion.dll, use UnityFusion source instead.

# 2.0.0-preview.35

## Added

- Added activate corresponding unity version with Dlls

# 2.0.0-preview.34

## Fixed

- Fixed the issue of "SDKEntryPoint not found" when there are differences in Unity versions 6000 or 2022.

# 2.0.0-preview.33

## Added

- Support Unity6 and Unity 2022, Use **UNITY_6000_0_OR_NEW** and **UNITY_2022_0_OR_NEW** to distinguish Unity versions

# 2.0.0-preview.32

## Fixed

- Fixed the issue that BaseBuildFeature did not execute the algorithm when Algorithm existed.
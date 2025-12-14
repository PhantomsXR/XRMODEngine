# 3.0.4

## Fixed

- Fixed UnityFusion not invoke

# 3.0.3

## Update

- Update core to newly version

# 3.0.2

## Fixed

- Fixed an issue where 'USE_AUDIO_MODULE' was invalid due to Foundation

# 3.0.1

## Changed

- Upgrade dependencies

# 2.0.6

## Fixed

- Compatible with Unity2022

# 2.0.5

## Added

- Added 'AudioModule' support

# 2.0.4

## Added

* Added `enum BindingPhase` to define explicit binding phases (`AddClass`, `SetValue`, `Activate`, `SetRenderer`)
  instead of relying on magic indexes.
* Added `IBindingStep.Phase` property for clear phase identification per binding step.
* Added `IBindingStep.ExecuteAsync()` as the unified asynchronous execution interface.
* Added detailed error handling and logging for each binding phase to improve debugging and fault tolerance.
* Added dictionary-based step registration (`Dictionary<BindingPhase, IBindingStep>`) for easier lookup and
  extensibility.

## Changed

* Changed constructor to accept `IEnumerable<IBindingStep>` instead of a fixed list; automatically builds a dictionary
  by `Phase`.
* Changed `BindScript()` to `BindScriptAsync()` — now executes phases sequentially in logical order and isolates errors
  per phase.
* Changed `BindScriptBatch()` to `BindScriptBatchAsync()` — executes each binding phase sequentially while running
  binders in parallel within each phase.
* Changed flow to be based on ordered phases (`OrderBy(s => s.Phase)`) rather than hardcoded index access.
* Changed exception handling strategy — single phase failures no longer stop the entire binding process.

## Removed

* Removed direct array index references like `bindingSteps[0]`, `bindingSteps[1]`, etc., improving scalability and
  readability.

## Fixed

* Fixed potential `NullReferenceException` in `BindScriptBatch()` when input arrays were empty or steps missing.
* Fixed inconsistent async handling that could block Unity’s main thread under heavy batch operations.
* Fixed lack of semantic mapping between binding logic and its execution order.

# 2.0.3

## Fixed

- Fix unable to get an object (script from a parent object) when initializing a child object script
- Fixed a type matching error when fetching a parent class type (child class object) resulting in components not
  fetching correctly.

# 2.0.2

## Added

- Added missing compilerServices clr of loadassets

## Fixed

- Editor: PrefabChangeMonitor no longer re-dirties an open prefab after Ctrl+S save.

# 2.0.0-pre.88

## Fixed

- Compatible with Unity2022

# 2.0.0-pre.87

## Fixed

- Compatible with Unity2022

# 2.0.0-pre.86

## Fixed

- Fixed UnityFusionType component get failed.

# 2.0.0-pre.85

## Added

- Added new clrs:
    - System_Func_1_ILTypeInstance_Binding
    - Dictionary_2_Int32_Func_1_ILTypeInstance_Binding
    - Dictionary_2_Type_List_1_Delegate_Binding
    - List_1_Delegate_Binding_Enumerator_Binding
    - List_1_Delegate_Binding
    - and more...

## Fixed

- Fixed multiple inheritance issue

## Changed

- Clearer responsibilities. Remove codes that are not part of your own responsibilities

# 2.0.0-pre.84

## Added

- Added ProcessMonoBinderBatch eventer

# 2.0.0-pre.83

## Fixed

-Fixed When the Child Object's activate is False, using UnityFusion Build With Convert does not execute.(#186)

# 2.0.0-pre.82

## Fixed

- Fixed asset reference with new code struct

# 2.0.0-pre.81

## Fixed

- Fixed 'OnBeforeSerialize' and 'OnAfterDeserialize' methods in last urp UniversalAdditionalCameraData_Binding

# 2.0.0-pre.80

## Fixed

- Fixed incorrect runtimeScript name on inspector

## Changed

- Improved performance
- Use EditorNotification instead
- Improved code structure

# 2.0.0-pre.79

## Added

- Add binding method for NGO system

# 2.0.0-pre.78

## Changed

- Optimize the project

# 2.0.0-pre.77

## Added

- Added FileInfo binding
- Added TimeSpan binding
- Added FileSystemInfo binding
- Added Resolution binding
- Added Application binding
- Added Exists,ReadAllBytes,LoadImage method clr redirection

## Changed

- Changed Enable UnityFusion to Enable UnityFusion Trace

# 2.0.0-pre.76

## Added

- Added missing `MinMaxCurve_Binding` clrs

# 2.0.0-pre.75

## Fixed

- Remove non-related scripts

# 2.0.0-pre.74

## Added

- Added Missing CLRs

# 2.0.0-pre.73

## Fixed

- Fixed MonoBinder execute order when use Object.InstantiateAsync

# 2.0.0-pre.72

## Fixed

- Fixed an automatic postprocessor injection error when injection is not required

# 2.0.0-pre.71

## Fixed

- Fixed convert to monobinder batch not work after exit play mode

# 2.0.0-pre.70

## Fixed

- Fixed Null Exception when call Codehook.Dispose

## Changed

- Changed List<MonoBehaviour> to List<XRMOD.Adapter>

# 2.0.0-pre.69

## Added

- Added UnityFusion Log Redirection

## Fixed

- Fixed XRMODBehaviour.Adapter NicifyName

## Changed

- Changed package dependencies

# 2.0.0-pre.68

## Fixed

- Fixed XRMODBehaviour not work when call InstantiateAsync

# 2.0.0-pre.67

## Fixed

- Fixed GetComponentsInParent,GetComponentsInChild type error

## Changed

- Removed useless files

# 2.0.0-pre.66

## Fixed

- Fixed the error of using LayerMask directly instead of LayerMask.Value
- Fixed an issue with MonoBinder/MonoInspector not parsing DataProperty fields with non-public types but with
  SerializeField

# 2.0.0-pre.65

## Added

- Added List<T> inject support

## Changed

- Changed DataProperty display style

# 2.0.0-pre.64

## Added

- Added Custom Data Property for MonoBinder support(Class Model)

# 2.0.0-pre.63

## Fixed

- Fixed List<UnityComponent>.AddRange bug
- Fixed batch convert To MonoBinder
- Add new clrs

## Changed

- Add `priority` for menu item

# 2.0.0-pre.62

## Fixed

- Fixed error after first-time installing

## Changed

- Combined all editor scripts into one editor folder

# 2.0.0-pre.61

## Fixed

- Fixed build error. Because the editor asmdef is not only Editor

# 2.0.0-pre.60

## Add

- Add support Localization component fixing

## Changed

- Remove the extra editor asmdef file. Merge them into UnityFusion.Editor.

# 2.0.0-pre.59

## Fixed

- Fixed RuntimeAssetReferenceDatabase load failed
- Fixed the Changelog's fixed tag from the previous version

# 2.0.0-pre.58

## Fixed

- Fixed load RuntimeAssetReferenceDatabase asset failed with in legacy project

# 2.0.0-pre.57

## Added

- Added load RuntimeAssetReferenceDatabase when xr-experience loaded
- Added auto collection Runtime asset references data when ConvertToMonoBinder

## Fixed

- Fixed incorrect type of Sprite and Texture2D when auto add asset reference object to Package tools contents
- Fixed List<T>/Array<T>/Unity Object support for ConvertToXRMODBehaviour

## Changed

- Separate ConvertToMonoBinder and ConvertToXRMODBehaviour from main file

# 2.0.0-pre.56

## Added

- Added add asset reference record for RuntimeAssetReferenceDatabase when ConvertToXRMODBinder

## Fixed

- Fixed Unity Component set value incorrect when Convert To XRMODBehaviour

# 2.0.0-pre.55

## Updated

- Update to support Unity6.1(Supported)

# 2.0.0-pre.54

## Fixed

- Fixed the error that the child object component could not be retrieved when MonoBinder was converted to
  XRMODBehaviour.

- Fixed serializer field data

# 2.0.0-pre.53

## Fixed

- Fixed Cross-domain multiple inheritance bug
  ```C#
  public class PlayerBase:XRMODBehaviour,IDamaage{}
  public class AIPlayer:PlayerBase{}
  
  // Error when call GetComponent<TutorialPlayer>()
  public class TutorialPlayer:AIPlayer{} 
  ```

# 2.0.0-pre.52

## Added

- Added MonoBinder to XRMODBehaviour

## Fixed

- Fixed Primitives data binding
- Fixed AnimationCurveArray data binding
- Fixed Vector2/3/4,Quaternion Array data binding

## Changed

- Changed MenuItem path to Tools/XR-MOD/Tools

# 2.0.0-pre.51

## Fixed

- Fixed **GetComponentsInChildren** Type error bug

# 2.0.0-pre.50

## Removed

- Removed useless adapter scripts of XRI

# 2.0.0-pre.49

## Added

- Add fix SDKInformation.asset process

# 2.0.0-pre.48

## Improved

- Improved UnityFusion Core. Slightly improved performance on accessing fields through aggressive inlining

# 2.0.0-pre.47

## Added

- Add XRMOD_INSTALL to defineconstraits

# 2.0.0-pre.46

## Added

- Add MaskableGraphic adapter
- Add Selectable adapter
- Add TMPro TextMesh clr

## Fixed

- Fix InvokeConstructor for MonoBinder

## Removed

- Remove **BundleDetails_Binding**

# 2.0.0-pre.45

## Added

- Add **InstantiateAsync** support
- Add **Diagnostics Stopwatch** Binding
- Add **AsyncInstantiateOperation GameObject** Binding
- Add **AsyncInstantiateOperation GameObject Awaiter** Binding
- Add **InstantiateParameters** Binding
- Add **LineRenderer List** Binding
- Add **Sprite List** Binding
- Add **Button List** Binding
- Add **UIImage List** Binding
- Add **RectTransform List** Binding
- Add **Canvas List** Binding
- Add **Canvas Group List** Binding
- Add **Toggle Group List** Binding
- Add **Toggle List** Binding
- Add **Dropdown List** Binding
- Add **TextMeshPro List** Binding
- Add **TextMeshProUGUI List** Binding
- Add **RawImage List** Binding
- Add **Slider List** Binding
- Add **Scrollbar List** Binding
- Add **InputField List** Binding
- Add **Particle System List** Binding
- Add **BoxCollider List** Binding
- Add **SphereCollider List** Binding
- Add **MeshCollider List** Binding
- Add **CapsuleCollider List** Binding
- Add **Character List** Binding
- Add **Animation List** Binding
- Add **Animator List** Binding
- Add **Quaternion List** Binding
- Add **MeshFilter List** Binding
- Add **MeshRenderer List** Binding
- Add **SplineContainer List** Binding
- Add **AudioSource List** Binding
- Add **AudioClip List** Binding
- Add **Light List** Binding
- Add **Sorting Group List** Binding
- Add **SpriteRenderer List** Binding
- Add **VideoPlayer List** Binding
- Add **Camera List** Binding

## Improved

- Optimize InstantiateCLRRedirection parameters name

# 2.0.0-pre.44

## Added

- Add trigger action to start process MonoBinder via ActionNotificationCenter
- Add DateTime getNow clr
- Add UnityFusion Debug Service

## Fix

- Fix CLR direction and Optimize

## Remove

- Remove Convert To MonoBinder Button on XRMODBehaviour component. Use Right-click component context menu insead.
- Remove On Multiplayer Event callback

## Improved

- Optimize code struct
- Optimize XRMODBehaviourAdapter
- Optimize XRMODBehaviourAdapter Component display name

# 2.0.0-pre.43

## Added

- Add AudioClipData asset load

## Fix

- Fix List<System.Int32> delegate Adapter missing error
- Fix MonoBinder error when bind the LayerMask field
- Fix when PackageTools does not have a project or is not opened, using binder to fill in asset will result in an error.

## Change

- Change Instantiate function name to DoBinding in the Hooks/Runtime/Utility.cs
- Change Convert To MonoBinder button to Context Menu(Right click the target)

## Improved

- Improved Delegate register of primitive types

# 2.0.0-pre.42

## Improved

- Improved location Services useage

# 2.0.0-pre.41

## Removed

- Remove Try catch in ILIntepreter

# 2.0.0-pre.40

## Fix

- Fix module clr not injected into application domain

# 2.0.0-pre.39

## Add

- Add Particle sub mode clrs

## Fix

- List\<GameObject\> Binding failed

## Fix

- Fix ConstrainSource not found error
- Fix [Particle]Cannot find method:set_enabled in type:UnityEngine.ParticleSystem+RotationOverLifetimeModule

# 2.0.0-pre.38

## Fix

- Fix does not work with start method when script componenthas not OnEnable method

# 2.0.0-pre.37

## Fix

- Fix when the object is in the Deactivate state, MonoBinder start still executes.

# 2.0.0-pre.36

## Removed

- Removed Fusion2 dependency from Clr. Move fusion2 clr to photon module UnityFusion.

# 2.0.0-pre.35

## Added

- Add Events,Particles clrs
- Add missing clr types

## Improved

- Reduce GC
- Improved OnEvent GC

# 2.0.0-pre.34

## Fix

- Fixed the issue that a large number of GCs were generated when loading Assetbundles.

# 2.0.0-pre.33

## Fix

- Fix component array render of mono behaviour adapter inspector.

## Removed

- Removed uesless code.

# 2.0.0-pre.32

## Fix

- Fix double-click log redirection

# 2.0.0-pre.31

## Removed

- Removed LoadTTypeAssetRedirection.cs. And move to XRMODAPI UnityFusion
- Removed XRMOD-API Reference

# 2.0.0-pre.30

# 2.0.0-pre.29

# 2.0.0-pre.28

## Added

- [CLRs]: Added CLRs
- [Cores]: Move to Cores folder
- [Hooks]: Added Hooks
- [Adapters]: Added Adapters

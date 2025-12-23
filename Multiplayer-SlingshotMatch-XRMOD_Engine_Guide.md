# XRMOD Engine Developer Guide

This guide provides a comprehensive overview of developing with the XRMOD Engine, based on the analysis of the `SlingshotMatch` project. It is written for developers familiar with Unity who want to understand the specific patterns and wrappers used in XRMOD.

## 1. How to use MonoBehaviour

In XRMOD Engine, you should generally derive from `XRMODBehaviour` instead of the standard `MonoBehaviour` for gameplay logic, especially if the component interacts with the XRMOD lifecycle or systems.

### Key Points
- **Inheritance**: Inherit from `XRMODBehaviour`.
- **Namespace**: `Phantom.XRMOD.Core.Runtime`.
- **Attributes**: You can still use standard attributes like `[RequireComponent]`.
- **DontConvertToMonoBinder**: Use `[DontConvertToMonoBinder]` for fields that shouldn't be automatically processed by XRMOD's binding system.
- **Awake Check**: **CRITICAL**. You MUST check `if (!enabled) return;` at the start of `Awake`. This is because standard Unity `Awake` can run before the XRMOD Binding system has finished initializing the object, which leads to errors. The Binding system relies on this check to safely initialize properties.

### Example
```csharp
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Core.Runtime.Attribute;
using UnityEngine;

public class MyGameLogic : XRMODBehaviour
{
    [SerializeField] private float speed = 10f;

    [SerializeField, DontConvertToMonoBinder]
    private int internalState;

    private void Awake()
    {
        // CRITICAL: Avoid executing before XRMOD Binding system finishes
        if (!enabled) return;

        // Initialization logic here
    }

    private void Start()
    {
        // Standard Unity lifecycle works
    }
}
```

## 2. How to use Netcode for GameObject

XRMOD Engine uses a wrapper around Unity's Netcode for GameObjects (NGO). It abstracts some complexity but introduces a unique "String-based RPC" pattern.

### Core Components
- **XRMODNetworkBehaviour**: Derive from this or component add `XRMODNetworkBehaviour` to your GameObject.
- **NetworkVariables**: Use custom wrappers like `IntegerNetworkVariable`, `ByteNetworkVariable`, `UintNetworkVariable`.
- **RPCs**: Instead of `[ServerRpc]` attributes, register methods dynamically using strings.

### RPC System (String-based)
XRMOD uses a manual registration system for RPCs, sending data as JSON strings.

1.  **Registering RPCs**: In `Awake`, register your methods.
2.  **Sending RPCs**: Use `SendToServerRpc` or `SendToEveryoneRpc`.
3.  **Receiving RPCs**: Implement a method with signature `void MethodName(string data, RpcParams params)`.

### Lifecycle
- **OnNetworkSpawnEvent**: Listen to this event instead of overriding `OnNetworkSpawn`.

### Example
```csharp
using LitJson;
using Phantom.XRMOD.NetcodeModule.Runtime;
using Unity.Netcode;
using UnityEngine;

[RequireComponent(typeof(XRMODNetworkBehaviour))]
public class MyNetworkedObject : XRMODBehaviour
{
    private XRMODNetworkBehaviour networkBehaviour;
    private IntegerNetworkVariable scoreNetVar;

    private void Awake()
    {
        networkBehaviour = GetComponent<XRMODNetworkBehaviour>();
        
        // 1. Get Network Variable
        networkBehaviour.TryGetNetworkVariable("Score", out scoreNetVar);

        // 2. Register RPC
        networkBehaviour.RegisterRpcMethods(nameof(OnScoreUpdatedRpc), OnScoreUpdatedRpc);
        
        // 3. Listen to Spawn
        networkBehaviour.OnNetworkSpawnEvent.AddListener(OnNetworkSpawned);
    }

    private void OnNetworkSpawned()
    {
        if (networkBehaviour.IsServer)
        {
            scoreNetVar.Value = 100;
        }
    }

    // Call this to trigger RPC
    public void UpdateScore(int newScore)
    {
        var data = new ScoreData { Value = newScore };
        networkBehaviour.SendToEveryoneRpc(nameof(OnScoreUpdatedRpc), JsonMapper.ToJson(data));
    }

    // RPC Implementation
    private void OnScoreUpdatedRpc(string data, RpcParams rpcParams)
    {
        var scoreData = JsonMapper.ToObject<ScoreData>(data);
        Debug.Log($"Score updated: {scoreData.Value}");
    }
}

public class ScoreData { public int Value; }
```

## 3. How to Load Resources

Do not use `Resources.Load` or direct `Addressables` calls. Use the `XRMODAPI` provided via `SharedData` (or directly) to load assets asynchronously.

### API Methods
- `XRMODAPI.LoadAssetAsync<T>(string assetName)`: Load a single asset.
- `XRMODAPI.LoadAssetsAsync<T>(string[] assetNames)`: Batch load multiple assets.
- **Note**: Assets seem to be referenced by their addressable name or key string.

### Example
```csharp
// In your SharedData or Manager
public async void LoadGameAssets()
{
    try 
    {
        // Load a single prefab
        GameObject enemyPrefab = await XRMODAPI.LoadAssetAsync<GameObject>("EnemyPrefab");
        
        // Load multiple audio clips
        string[] soundNames = new [] { "Explosion", "Jump" };
        AudioClip[] sounds = await XRMODAPI.LoadAssetsAsync<AudioClip>(soundNames);
        
        // Instantiate
        GameObject.Instantiate(enemyPrefab);
    }
    catch (Exception e)
    {
        Debug.LogError($"Failed to load assets: {e}");
    }
}
```

## 4. How to call OpenXR API

XRMOD Engine relies on **Unity's XR Interaction Toolkit (XRI)**. You typically do not call OpenXR directly.

### Usage
- Use `UnityEngine.XR.Interaction.Toolkit` components.
- Use `UniversalXRInput` helper for global input state.
- Handle input via standard XRI Interfaces like `IXRSelectInteractor`, `SelectEnterEventArgs`.

### Example
```csharp
using UnityEngine.XR.Interaction.Toolkit;

public void OnSelectEntered(SelectEnterEventArgs args)
{
    // Check handedness (custom helper often used)
    if (args.interactorObject is XRBaseInputInteractor inputInteractor)
    {
         Debug.Log($"Selected by {inputInteractor.xrController}");
    }
}
```

## 5. How to Optimize

1.  **Object Pooling**: use `UniPool`.
    *   `UniPool.Register(prefab, parent)`
    *   `UniPool.Fill(prefab, count)`
    *   `UniPool.Get(prefab)`
    *   `UniPool.Release(instance)`
2.  **Batch Loading**: Use `LoadAssetsAsync` to reduce overhead when loading multiple assets.
3.  **Shader Warming**: Use `ShaderVariantCollection.WarmUp()` after loading shaders to prevent hitching.
4.  **Async/Await**: The engine heavily uses async/await for loading to avoid blocking the main thread.

### Pooling Example
```csharp
using Phantom.XRMOD.XRMODUtilites.Runtime.UniPool;

// Init
UniPool.Register(bulletPrefab, transform);
UniPool.Fill(bulletPrefab, 20);

// Use
var bullet = UniPool.Get(bulletPrefab);

// Return
UniPool.Release(bullet.GameObject);
```

## 6. Differences from Traditional Unity API

| Feature | Traditional Unity | XRMOD Engine |
| :--- | :--- | :--- |
| **Base Class** | `MonoBehaviour` | `XRMODBehaviour` |
| **Networking** | `NetworkBehaviour` + `[ServerRpc]` | `XRMODNetworkBehaviour` + `RegisterRpcMethods` |
| **RPC Data** | Typed arguments | serialized JSON string |
| **Spawning** | `NetworkObject.Spawn()` | `NetcodeServiceAPI.GetInstance.RegisterNetworkPrefabs` + Spawn |
| **Resources** | `Resources.Load` / `Addressables` | `XRMODAPI.LoadAssetAsync` |
| **Pooling** | `ObjectPool<T>` (manual) | `UniPool` (static utility) |
| **Dependency Injection** | Manual / Zenject | `VContainer` integrated |

## 7. Detailed Case Study: `SlingshotArea`

The `SlingshotArea` class demonstrates most of these patterns:

1.  **Inheritance**: `public class SlingshotArea : XRMODBehaviour, IShotable`
2.  **Components**: `[RequireComponent(typeof(XRMODNetworkBehaviour))]`
3.  **Net Vars**: 
    ```csharp
    private IntegerNetworkVariable seatIdNetworkVariable;
    // ...
    networkBehaviour.TryGetNetworkVariable(nameof(seatIdNetworkVariable), out seatIdNetworkVariable);
    ```
4.  **RPC Registration**:
    ```csharp
    networkBehaviour.RegisterRpcMethods(nameof(OnSelectEnteredRpc), OnSelectEnteredRpc);
    ```
5.  **RPC Sending**:
    ```csharp
    networkBehaviour.SendToEveryoneRpc(nameof(OnSelectEnteredRpc), JsonMapper.ToJson(rpcData));
    ```
6.  **Interaction**: Uses `XRISelectFilter` and `XRBaseInteractable`.
7.  **Pooling**: Registers and uses `UniPool` for projectiles.

This architecture encourages a separation of concerns where visual/gameplay logic is strictly separated from the networking transport layer, mediated by `XRMODNetworkBehaviour` and JSON serialization.

## 8. Unityfusion Limitations

The project runs on a hot-update framework referred to as **Unityfusion** (replacing ILRuntime). Developer must be aware of specific constraints when writing code:

1.  **No `AddComponent<T>`**: You **cannot** directly call `gameObject.AddComponent<MyClass>()` if `MyClass` is a script inside your hot-update package.
    *   *Workaround*: Use `XRMODAPI` to load prefabs with scripts already attached, or use the binding system.
2.  **Inheritance Restrictions**: You cannot inherit directly from `MonoBehaviour` or any other Unity base class (like `NetworkBehaviour`) if it is not wrapped.
    *   *Rule*: Always inherit from `XRMODBehaviour` or exposed AOT classes/interfaces.
3.  **Generics**: While supported, excessive use of complex generics in hot paths can inherit performance overhead or require specific AOT adapters. Use standard types when possible.
4.  **Delegates**: Passing delegates (Action/Func) to Unity APIs (AOT) requires the Unity API to be properly adapted. If you encounter issues with callbacks, ensure the delegate type is supported by the engine adapters.
5.  **Threading**: As with standard Unity, the Unityfusion domain is single-threaded and bound to the main thread.
6.  **No ScriptableObject Definitions**: You cannot define new `ScriptableObject` classes in the hot-update assembly.
    *   *Workaround*: Use POCOs (Plain Old CLR Objects) or data structures serialized via JSON/XML for configuration, or use existing AOT ScriptableObjects.
7.  **No Third-Party Plugin Updates**: You cannot include or update Dlls/Plugins inside the hot-update package. All native plugins must be pre-installed in the host project (AOT).
8.  **JSON Serialization**: **Do not** use `UnityEngine.JsonUtility` or `Newtonsoft.Json`.
    *   *Rule*: Use `LitJson` (included in the engine) for all JSON operations.

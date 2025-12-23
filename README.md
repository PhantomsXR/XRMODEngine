# XRMODNetcode Module

The **XRMODNetcode** module provides a comprehensive, production-ready networking layer built on Unity Netcode for GameObjects. It simplifies multiplayer development by offering session management, object pooling, RPC utilities, and specialized systems like tabletop networking.

## 🚀 Key Features

- **Unified Session API**: Create, join, and manage multiplayer sessions with client-server, Unity Relay, or distributed authority topologies
- **Network Object Management**: Simplified spawning, despawning, and registration of network prefabs and player objects
- **Tabletop System**: Ready-to-use seat management for turn-based or tabletop experiences
- **Lag Compensation**: Built-in tools for client-side prediction and server reconciliation
- **Object Pooling**: Efficient `NetworkObjectPool` for frequently spawned/despawned objects
- **Custom Network Variables**: Extended variable types for strings, Unity primitives, and custom data
- **Message Bridge**: Seamless integration with XRMOD's UnityFusion messaging system

## 📦 Module Structure

- **NetcodeServiceAPI.cs**: Main singleton API for session and object management
- **Models**: Configuration classes (`BaseSessionConfig`, `HostingBaseSessionConfig`, topology types, regions)
- **Components**: Network behaviors, XRI integration, lag compensation, and network discovery
- **Systems/TabletopSystem**: Seat assignment, player connection handling, and tabletop game logic
- **NetworkVariables**: Custom network-synchronized variable types
- **NetworkSerializable**: Serializable data structures for network transmission
- **Utilities**: Message readers/writers, object pooling, and NetworkManager extensions
- **EventArgs**: Event argument classes for netcode lifecycle events

## 🛠 Getting Started

### Creating or Joining a Session

Use `NetcodeServiceAPI` to create or join multiplayer sessions:

```csharp
using Phantom.XRMOD.NetcodeModule.Runtime;

// Configure session
var config = new BaseSessionConfig
{
    SessionCode = "MyGameRoom",
    MaxPlayer = 4,
    TopologyTypes = NetworkTopologyTypes.UnityRelay,
    Private = true
};

// Create or join session
var session = await NetcodeServiceAPI.GetInstance.CreateOrJoinSession("MyGame", config);
Debug.Log($"Joined session: {session.Name}");
```

### Spawning Network Objects

Register and spawn networked prefabs:

```csharp
// Register a network prefab
NetcodeServiceAPI.GetInstance.RegisterPrefab(myNetworkPrefab);

// Spawn a network object (server/host only)
var spawnedObject = NetcodeServiceAPI.GetInstance.SpawnNetworkGameObject(
    myNetworkPrefab,
    Vector3.zero,
    Quaternion.identity
);

// Spawn as a player object
var playerObject = NetcodeServiceAPI.GetInstance.SpawnPlayerGameObject(
    clientId,
    playerPrefab,
    spawnPosition,
    Quaternion.identity
);
```

### Using the Tabletop System

The tabletop system automatically manages seats for turn-based games:

```csharp
// Request any available seat
TableTopNetworkedSystem.GetInstance.RequestAnySeat(NetworkManager.LocalClientId);

// Request a specific seat
TableTopNetworkedSystem.GetInstance.RequestSeat(seatId: 2);

// Subscribe to seat change events
TableTopNetworkedSystem.GetInstance.OnJoinSeat.AddListener(() => {
    Debug.Log("Joined a seat!");
});
```

### Network Variables

Network variables in XRMOD are component-based. They must be attached to the same GameObject as an `XRMODNetworkBehaviour` and are retrieved via a unique Key.

```csharp
using Phantom.XRMOD.NetcodeModule.Runtime;
using UnityEngine;

public class PlayerProfile : XRMODBehaviour
{
    // These components should be attached to the same GameObject
    private Fixed32StringNetworkVariable playerNameVar;
    private XRMODNetworkBehaviour networkBehaviour;

    private void Awake()
    {
        // Get the bridge component
        networkBehaviour = GetComponent<XRMODNetworkBehaviour>();
        
        // Retrieve variables by their Key (set in Inspector or via nameof)
        if (networkBehaviour.TryGetNetworkVariable(nameof(playerNameVar), out playerNameVar))
        {
            // Subscribe to changes if enabled
            playerNameVar.OnValueChanged.AddListener((oldVal, newVal) => {
                Debug.Log($"Name changed: {newVal}");
            });
        }
    }

    public void UpdateName(string newName)
    {
        if (networkBehaviour.IsServer) // Only server/owner can write by default
        {
            playerNameVar.Value = newName;
        }
    }
}
```

## 💡 Best Practices

1. **Use NetcodeServiceAPI**: Always access networking features through the singleton `NetcodeServiceAPI.GetInstance`
2. **Register Prefabs Early**: Register all network prefabs before starting the session
3. **Choose the Right Topology**:
   - **ClientServer**: For competitive games requiring authoritative server logic
   - **UnityRelay**: For peer-to-peer casual games without dedicated servers
   - **DistributedAuthority**: For cooperative experiences with no single authority
4. **Handle Disconnections**: Subscribe to `OnPlayerStateChanged` to handle player joins/leaves gracefully
5. **Use Object Pooling**: For frequently spawned objects (projectiles, effects), use `NetworkObjectPool`

## ⚠️ Common Pitfalls

- **Missing Prefab Registration**: Spawning fails if prefabs aren't registered via `RegisterPrefab()` first
- **Server-Only Operations**: Methods like `SpawnNetworkGameObject` only work on the server or host
- **Session Mismatch**: Ensure all clients use the same `SessionCode` and `gameName` when joining
- **Region Selection**: For Unity Relay, choose the region closest to your target audience for best latency
- **Topology Limitations**: Not all features work in every topology (e.g., distributed authority has different ownership rules)

## 🔌 Integration with XRMOD

The Netcode module integrates seamlessly with other XRMOD systems:

- **UnityFusion**: Automatic message bridging via `UnityFusionMessageBridge`
- **ActionNotification**: Network events posted to `ActionNotificationCenter`
- **XRMODInput**: XRI-aware network behaviors for VR/AR controllers

---
*Developed by PhantomsXR Ltd.*

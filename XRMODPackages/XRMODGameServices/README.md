# XRMOD Game Services

Take your game to the next level without having to worry about maintaining or scaling your back-end infrastructure. **XRMOD Game Services (GS)** simplifies game development challenges by providing a unified set of tools for authentication, voice communication, leaderboards, cloud saving, and in-app purchases.

---

## 📖 Table of Contents

- [Overview](#overview)
- [Quick Start](#quick-start)
- [Core Modules](#core-modules)
  - [Authentication](#authentication)
  - [Voice](#voice)
  - [Cloud Save](#cloud-save)
  - [Leaderboard](#leaderboard)
  - [In-App Purchase](#in-app-purchase)
  - [Friends](#friends)
- [Best Practices](#best-practices)
- [Common Pitfalls](#common-pitfalls)

---

## 🌟 Overview

XRMOD Game Services is designed to be a high-level wrapper around Unity Gaming Services (UGS) and other third-party providers. It offers a consistent API regardless of the underlying platform, allowing developers to focus on gameplay logic rather than infrastructure.

---

## 🚀 Quick Start

To use XRMOD Game Services, you must initialize the core manager early in your game's lifecycle.

> [!IMPORTANT]  
> You must manually call `InitializeUnityServices` before using any other game services.

```csharp
using Phantom.XRMOD.GameServices.Runtime;

// Basic initialization
XRMODGameServicesManager.GetInstance.InitializeUnityServices();

// Initialization with a specific profile (useful for testing)
await XRMODGameServicesManager.GetInstance.InitializeUnityServicesAsync("Player_Alpha");
```

---

## 📦 Core Modules

### 🔐 Authentication

The entry point for all player-related services. Supports multiple platforms and anonymous login.

#### Supported Platforms
- **Anonymous**: No credentials required.
- **Username/Password**: Custom account management.
- **Third-Party**: Apple (`USE_APPLE_AUTHENTICATION`), Google (`USE_GOOGLE_AUTHENTICATION`), Meta (`USE_META_AUTHENTICATION`).

#### Usage Example
```csharp
// Sign in anonymously
await AuthenticationSystemManager.SignInWithAnonymous();

// Sign in with Username/Password
await AuthenticationSystemManager.SignInUserNameWithPassword("myUser", "myPass", (err) => Debug.LogError(err));

// Check state
if (AuthenticationSystemManager.IsSignedIn) {
    var userInfo = AuthenticationSystemManager.GetUserInfo();
    Debug.Log($"Welcome, {userInfo.player_name}!");
}
```

---

### 🎙️ Voice

Scalable, cross-platform voice and text communication.

#### Supported Providers
- **Vivox**: Define `USE_VIVOX`.
- **Agora**: Define `USE_AGORA_RTC`.
- **Photon**: Define `USE_PHOTON_VOICE`.

#### Usage Example
```csharp
// Join a spatialized voice channel
VoiceSystemManager.GetInstance.JoinVoiceChannel("Room_01", JoinChannelType.Positional);

// Mute self
VoiceSystemManager.GetInstance.MuteSelfMicrophone(true);
```

> [!TIP]  
> Register for voice events via the `ActionNotificationCenter` using `VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY`.

---

### ☁️ Cloud Save

Store player data (levels, inventory, settings) securely in the cloud.

#### Initialization
Add `USE_UNITY_CLOUD_SAVE` to your project's scripting define symbols.

#### Usage Example
```csharp
var myData = new Dictionary<string, object> { { "HighScore", 5000 }, { "Stage", "Volcano" } };
await CloudSaveSystemManager.GetInstance.SavePlayerData(myData);

// Load data
var keys = new HashSet<string> { "HighScore" };
var results = await CloudSaveSystemManager.GetInstance.LoadPlayerData(keys);
if (results.TryGetValue("HighScore", out var item)) {
    int score = item.Value.GetAs<int>();
}
```

---

### 🏆 Leaderboard

Track and display player rankings. Built on top of Unity Leaderboard.

#### Initialization
Add `USE_UNITY_LEADERBOARD` to your project's scripting define symbols.

#### Usage Example
```csharp
// Update score
var scoreArgs = new AddOrUpdateScoreArgs { LeaderboardId = "GlobalTop", Score = 100 };
await LeaderboardSystemManager.GetInstance.AddOrUpdateScore(scoreArgs);

// Get rankings
var listArgs = new GetScoreListArgs { LeaderboardId = "GlobalTop", Limit = 10 };
var scores = await LeaderboardSystemManager.GetInstance.GetScoreList(listArgs);
```

---

### 💰 In-App Purchase

Standardized interface for purchasing digital goods.

#### Usage Example
```csharp
// Initialize products
await InAppPurchaseManager.GetInstance.Initialization(myProductArray);

// Buy a product
bool success = await InAppPurchaseManager.GetInstance.BuyProduct("gold_pack_01");
```

---

### 👥 Friends

Manage player relationships, presence, and friend requests.

#### Usage Example
```csharp
// Send friend request
RelationshipsManager.GetInstance.AddFriendAsync("AwesomePlayer_99");

// Check friends list
var friends = RelationshipsManager.GetInstance.GetFriends();
foreach(var friend in friends) {
    Debug.Log($"{friend.Profile.Name} is currently {friend.Presence.Availability}");
}
```

---

## 🛠 Best Practices

1. **Async Await**: Most GS operations are network-based. Always use the `Async` versions with `await` to keep the UI responsive.
2. **Profile Management**: Use unique profile names during `InitializeUnityServices` when testing multiple clients on the same machine.
3. **Event Subscriptions**: Subscribe to `GameServicesReady` on the `XRMODGameServicesManager` to ensure all systems are up before starting gameplay.

---

## ⚠️ Common Pitfalls

- **Missing Defines**: Many modules (Voice, IAP, Cloud Save) require specific scripting define symbols (e.g., `USE_VIVOX`). Check the module documentation for the correct symbol.
- **Auth Not Initialized**: Calling Cloud Save or Leaderboard before the player is signed in will result in authorization errors.
- **Profiling in Editor**: When testing in the Unity Editor, some services may behave differently than on a physical device (especially IAP and Voice).
- **Unity Fusion**: This package explicitly ignores Unity Fusion networking modules by default.

---

*For licensing requests, contact [nswell@phantomsxr.com](mailto:nswell@phantomsxr.com).*
*Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.*
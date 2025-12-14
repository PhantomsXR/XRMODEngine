# XRMOD Game Services

Take your game to the next level without having to worry about maintaining or scaling your back-end infrastructure.
XRMOD-GS simplifies many game development tasks and challenges.

[TOC]  
[Authentication](#authentication)    
[Voice](#voice)  
[Leaderboard](#leaderboard)  
[Cloud Save](#cloudsave)

> You must manual to call `InitializeUnityServices(string _profileName = null)` to initialize XRMOD game services.
---

# Authentication

# How to use?

if using it with special platform: Apple/Google/Meta etc, you must add define for you Unity Project.

## About Credential

```C#
[System.Serializable]
public class Credential
{
    public string Token;
    public string Name;
    public string Email;
    public string AvatarUrl;
}
```

> Apple platform has not provide avatar, so avatar url will empty.

## SignIn

### Custom UserName with Password

**Method**

```C#
 public static void SignInUserNameWithPassword(String _userName,String _pwd);
 public static void SignUpUserNameWithPassword(String _userName,String _pwd);
 public static void UpdateUserNamePassword(String _userName,String _pwd);
```

**Example**

```C#
 AuthenticationManager.SignUpUserNameWithPassword("XRMODUser","XRMOD@User");
 AuthenticationManager.SignInUserNameWithPassword("XRMODUser","XRMOD@User");
 AuthenticationManager.UpdateUserNamePassword("XRMODUser","XRMOD@User");
```

---

### Apple platform

1. Add **USE_APPLE_AUTHENTICATION** to your project setting
2. Call **AuthenticationManager.SignInWithApple** to signin

**Method**

```C#
 public static void SignInWithApple(Action<Credential> _signSuccess = null,Action<string> _signFailed = null);
```

**Example**

```C#
AuthenticationManager.SignInWithApple(_credential=>{},Debug.LogError);
```

----

### Google platform

1. Add **USE_Google_AUTHENTICATION** to your project setting
2. Call **AuthenticationManager.SignInWithGoogle** to signin

**Method**

```C#
 public static void SignInWithGoogle(Action<Credential> _signSuccess = null,Action<string> _signFailed = null);
```

**Example**

```C#
AuthenticationManager.SignInWithGoogle(_credential=>{},Debug.LogError);
```

----

### Meta platform

1. Add **USE_META_AUTHENTICATION** to your project setting
2. Call **AuthenticationManager.SignInWithMeta** to signin

**Method**

```C#
 public static void SignInWithMeta(Action<Credential> _signSuccess = null,Action<string> _signFailed = null);
```

**Example**

```C#
AuthenticationManager.SignInWithMeta(_credential=>{},Debug.LogError);
```

### SignInWithAnonymous

**Method**

```C#
public static async Task SignInWithAnonymous()
```

**Example**

```C#
AuthenticationManager.SignInWithAnonymous();
```

### SignOut

Nothing special needs to be done, just call **AuthenticationManager.SignOut()**

### GetUserInfo

Nothing special needs to be done, just call **AuthenticationManager.GetUserInfo()**

### SignIn or Authorize State

Nothing special needs to be done, just call

- AuthenticationManager.IsSignedIn
- AuthenticationManager.IsAuthorized
- AuthenticationManager.IsExpired

---

# Voice

With Voice as your communication platform, you can offer cross-platform communications to your players and scale
seamlessly as you grow.

## How to use?

You must Add `USE_XXXX` define to your project config of Unity. And must installed Authentication System.

- Vivox -> USE_VIVOX
- Agora -> USE_AGORA_RTC
- PHOTON -> USE_PHOTON_VOICE

## Event Callback

You can register event callbacks with ActionNotificationCenter and use the VoiceEventKey in NotificationData to identify
the event type.

- ActionNotificationCenter.DefaultCenter.AddObserver(OnVoiceEvent,
  VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY);
- Convert BaseNotificationData to voiceNotificationDataArgs in OnVoiceEvent function.

### Example

```C#
void Start(){
    ActionNotificationCenter.DefaultCenter.AddObserver(OnVoiceEvent,
  VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY);
}

void OnVoiceEvent(BaseNotificationData _data){
 if (_data is VoiceNotificationDataArgs tmp_VoiceNotification){
       switch (tmp_VoiceNotification.VoiceEventKey){
            //....    
       }
 }    
}
```

## APIs

- Initialize(string _configuration,Voice3DProperties _voice3DProperties)
- DeInitialize()
- CreateVoiceChannel(string _channelName, JoinChannelType _joinChannelType)
- JoinVoiceChannel(string _channelName, JoinChannelType _joinChannelType)
- LeaveVoiceChannel()
- MuteSelfMicrophone(bool _muted)
- MuteOtherMicrophone(bool _muted, string _channelId, string _userId)
- BlockUser(bool _block, string _channelId, string _userId)
- List<VoiceParticipant> GetParticipants()

---

# Leaderboard

XRMOD Leaderboard is an adaptation package for Unity Leaderboard.

## How to use?

You must Add `USE_UNITY_LEADERBOARD` define to your project config of Unity. And must installed Authentication System.

## APIs

> Before calling the leaderboard API, you must first try the Authentication System for user login.

- LeaderboardSystemManager.AddOrUpdateScore
- LeaderboardSystemManager.GetScoreList
- LeaderboardSystemManager.GetPlayerScore

---

# CloudSave

## How to use?

You must Add `USE_UNITY_CLOUD_SAVE` define to your project config of Unity. And must installed Authentication System.

## APIs

> Before calling the CloudSave API, you must first try the Authentication System for user login.

- Task<bool> SavePlayerData(Dictionary<string, object> _saveData)
- Task<Dictionary<string, Item>> LoadPlayerData(HashSet<string> _keys)
- void Delete(string _key)
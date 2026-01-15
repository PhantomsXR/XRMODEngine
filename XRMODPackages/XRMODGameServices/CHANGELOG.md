# 1.0.9
## Fixed
- Fixed `XRMODGameServicesManager` hanging when Vivox initialization times out. Added `OnInitializationTimeout` handling to ensure ready callback is invoked.

# 1.0.8
## Updated
- Update commit and docs
# 1.0.6

## Fixed

- Fixed namespace ref error on Rokid platform authentication

# 1.0.5

## Fixed

- Fixed services ready checking

# 1.0.4

## Changed

- All services are initialized and connected to the cloud before performing callbacks

# 1.0.3

## Fixed

- Fixed Set3DAudio method not found error when vivox not enabled

# 1.0.2

## Fixed

- Fixed CheckRegion not exist error

# 1.0.1

## Changed

- **Voice-Vivox**: Set ParticipantUpdateFrequency to TenPerSecond

# 1.0.0-preview.44

## Added

- **Voice-Vivox**: Added Voice3DTracking component

## Fixed

- **Voice-Vivox**: Fixed VoiceEnventKey value

# 1.0.0-preview.43

## Changed

- Optimize authentication system methods. Now removed the callback on SignIn method, use
  SignedInCallback,SignOutCallback etc instead.

# 1.0.0-preview.42

## Fixed

- Fixed purchaseAPI error when build at visoinOS platform.

# 1.0.0-preview.41

## Changed

- Optimize the project

# 1.0.0-preview.40

## Fixed

- Fixed Meta InAppPurchased

# 1.0.0-preview.39

## Fixed

- Fixed incorrect username when use meta signin

# 1.0.0-preview.38

## Added

- Added InitializeUnityServicesAsync method

# 1.0.0-preview.37

## Changed

- Removed Unity version limited

# 1.0.0-preview.36

## Changed

- Update dependencies package version

# 1.0.0-preview.35

## Added

- Added new clrs for leaderboard

# 1.0.0-preview.34

## Fixed

- Fixed use GS API error when GS not signin
- Fixed signin callback is executed after logging in

# 1.0.0-preview.33

## Fixed

- Fixed AppleSignIn error

# 1.0.0-preview.32

## Added

- Added UnityEditor In-App Purchase simualtor

# 1.0.0-preview.31

## Changed

- Changed the original callback API to an asynchronous API

# 1.0.0-preview.30

## Added

- Added Meta Quest In-App Purchase support

## Changed

- Redesgin the In-App Purchase structure

# 1.0.0-preview.29

## Fixed

- Fixed signin logic: An error occurred when different devices authorize the same account.

# 1.0.0-preview.28

## Added

- Added **XRMOD_INSTALL** Define Constraints

# 1.0.0-preview.27

## Fixed

- [Authentication]: Fixed Anonymous Signned callback not executed

## Removed

- [Cores]: Removed auto initializeUnityServices. Now need manual to call InitializeUnityServices method to initialize.

# 1.0.0-preview.26

## Fixed

- [Authentication]:Fixed refresh player name bug on meta platform

# 1.0.0-preview.25

## Added

- Added meta platform plugin to versionDefines

## Removed

- Remove user_name field from UserInfoModel. Use player_name instead.

## Changed

- Changed the IplatformSignInProvider.Initialize() to Initialize(Action<UserInfoModel> _successCallback,Action<string> _
  failedCallback)

# 1.0.0-preview.24

## Fixed

- Fixed Meta account sign in

# 1.0.0-preview.23

## Fixed

- Fixed missing Meta Platform SDK error

``
You must install Meta platform sdk from Unity Asset Store(https://assetstore.unity.com/packages/tools/integration/meta-xr-platform-sdk-262366) by manual.
``

# 1.0.0-preview.22

## Fixed

- Fixed Meta signin "USE_META_AUTHENTICATION" define constraint

# 1.0.0-preview.21

## Removed

- Remove Check region clr

# 1.0.0-preview.20

## Change

- Remove Region checking. Move to the Unity Services Core package

# 1.0.0-preview.19

## Added

- [Voice]: Add Direct Text Message support

# 1.0.0-preview.18

## Added

- [Voice]: Add **GetParticipant(string _userName)** API

## Fixed

- [ClrDelegate]: Fixed `(Phantom.XRMOD.GameServices.Runtime.VoiceParticipant, System.Boolean)` action delegate key not
  found
  error.

# 1.0.0-preview.17

## Fixed

- [CLRs]: Fixed crls injected bug
- [Authentication]: Fixed clr userinfor reflection bug
- [Authentication]: Fixed cloud save user information bug
- [CloudSave]: Fixed 401 authorize bug

## Add

- [CloudSave]: Add save file api
- [Clrs]: Add missing clrs

# 1.0.0-preview.16

## Fixed

- [Authentication]: Fixed SignInWithAppId
- [Friends]: Fixed GetPlayerName word when empty bug
- [Core]: Change initialization execute timeline

# 1.0.0-preview.15

## Fixed

- [Authentication]:  'LoginOptions' is an ambiguous reference between 'AppleAuth.Enums.LoginOptions' and '
  Unity.Services.Vivox.LoginOptions'

# 1.0.0-preview.14

## Fixed

- [Authentication]: AppleAuth Not found in SignInWith Apple Provider

# 1.0.0-preview.13

## Added

- [Authentication]: Add Rokid platform sign in
- [Authentication]: Add player_name\mobile\accoundId\user_name to UserInfoModel

## Fixed

- [Core]: Fixed authentication services initialization timing

# 1.0.0-preview.12

## Fixed

- [Authentication]: Fixed SignIn after SignOut error

# 1.0.0-preview.11

## Fixed

- [Authentication]: Fixed SignIn username with pwd user info error

## Improved

- [Authentication]: Change Action callback(signin,signup, failed) to event

# 1.0.0-preview.10

## Added

- [Voice]: Add voice missing clr types

# 1.0.0-preview.9

## Added

- [Authentication]: Add Callback for SignInWithAnonymous (public static async Task SignInWithAnonymous(
  Action<UserInfoModel> _signSuccess = null, Action<string> _signFailed = null)).

## Fixed

- [Authentication]: Fixed SignIn with cache callback not work.

# 1.0.0-preview.8

## Fixed

- [Clrs]: Fixed all clr register

# 1.0.0-preview.7

## Added

- [Authentication]: Add SignInCallback:
    - ExpiredCallback
    - SignInCodeExpiredCallback
    - SignInCodeReceivedCallback
    - SignFailedCallback
- [Cores]: Add Initialize automatic
- [Cores]: Add InitializeUnityServices
- [Cores]: Add GameServicesFailed callback
- [Voice]: Add Voice System Initialized log
- [Voice]: Add LoggedIn and LoggedOut callback
- [Docs]: Add Support China region

## Changed

- [Authentication]: Simplify the initialization
- [Authentication]: Add Auto-generate Username
- [Voice]: Random coroutineBehaviour replace with XRMODGameServicesManager

# 1.0.0-preview.6

## Added

- [Voice]: Add OnLoggedOut,OnLogged,OnLoginFailed to OnVoiceEvent Callback
- [Voice]: Add Login retry loop(5 times)
- [Cores]: Add DontDestroyOnLoad for XRMODGameServicesManager

## Improved

- [Voice]: Optimized LeaveVoiceChannel, which previously caused users to log in when executing LeaveVoiceChannel.
- [Friends]: Add checks to avoid NullReference error

## Removed

- [Voice]: Removed useless codes

# 1.0.0-preview.5

## Added

- [InAppPurchase]: Add InAppPurchase

# 1.0.0-preview.4

## Fixed

- [Voice]: Fixed VivoxParticipant callback(
  ParticipantSpeechDetected,ParticipantMuteStateChanged,ParticipantAudioEnergyChanged) values not changed.
- [Voice]: Fixed Participant data not changed
- [Authentication]: Fixed SignInAnonymously not having player name bug

# 1.0.0-preview.3

## Added

- [Cores]: Add GameServicesReady event callback
- [Authentication]: Add `SignedInCallback?.Invoke()` to SignInWithAnonymous

# 1.0.0-preview.2

## Added

- [Voice]: Add new option for voice: Group,Echo,Positional
- [Voice]: Add Voice3DProperties class
- [Cores]: Add switches to each module
- [Cores]: Add Voice3DProperties
- [Cores]: Add ConfigurationArgs

## Change

- [Voice]: Change `VoiceManager.GetInstance.Initialize` 1 parameter to 2 parameters(string,Voice3DProperties).
- [Voice]: Change `JoinVoiceChannel(string _channelName)`
  to `JoinVoiceChannel(string _channelName, JoinChannelType _joinChannelType)`.
- [Voice]: Change VoiceManager to VoiceSystemManager
- [Authentication]: Change AuthenticationManager to AuthenticationSystemManager.
- [CloudSave]: Change CloudSaveManager to CloudSaveSystemManager

# Improved

- Update document of readme.

# 1.0.0-preview.1

First Comment.
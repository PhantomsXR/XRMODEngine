# 1.6.3
## Change
- Upgrade immersal sdk to 2.0.0

# 1.6.2
## Change
- Upgrade immersal sdk to 1.20.0

## Removed
- Remove ARWorldMapping codes

## Added
- Hololens libs


# 1.3.0
## Change
- Upgrade sdk to 1.17.1

## Fix
- UseFiltering not working

## Added
- Add map.metadata download

# 1.2.7
## Change
- Hide Immersal sdk Gameobject in hierarchy
- Will be auto instantiate Immersal sdk to hierarchy when ARMap has already in the hierarchy

## Added
- Add scroller bar to Map-download editor 

# 1.2.6
## Fix
- Fix MapDownloader window not appear

# 1.2.5
## Fix
- Fix the problem of unregistered point cloud data when loading different content (do not close the application)
- Fix turn off polling positioning after registration is complete
- Fix localized success regardless of success or failure
- Fix license will not be saved after Mapdownloader restarts Unity
- Fix `OnImmersalMapRegister` is not executed and the configuration cannot take effect

## Added
- Add new event callback:`OnReset`

## Changed
- Auto add `ImmersalMapRegister.cs` component to ARMap's gameobject

# 1.2.4
## Fix
- Map downloader `Data` not load when Unity opened

# 1.2.3
## Fix
- Fix map downloader uri incorrect problem
- 
# 1.2.2
## Added
- Add Immersal SDK map downloader 

# 1.1.2
## Fix
- Immersal SDK is released and then reloaded it. It will not be able to be relocated

# 1.1.1
## Fix
- Remove `metadata.json` checker
## Change
Upgrade Libs

## Change
- Upgrade sdk version to 1.16.1

# 1.0.0-alpha.1
## Change
Upgrade sdk version to 1.15
# 0.0.5-alpha.1
## Change
Upgrade sdk version to 1.14

# 0.0.4-alpha.1

## Change
update version number to 0.0.4-alpha.1

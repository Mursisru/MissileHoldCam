# Contributing

## Build

1. Install **Nuclear Option** and **BepInEx 5 x64** (same layout the game uses under Steam).
2. If the game is **not** at  
   `C:\Program Files (x86)\Steam\steamapps\common\Nuclear Option`,  
   copy `Directory.Build.user.props.example` to `Directory.Build.user.props` at the repo root and set `NuclearOptionRoot` to your install directory (no trailing backslash required).
3. Open `MissileHoldCam_Engine.slnx` in Visual Studio 2022 (or run MSBuild on the `.csproj`).
4. Build **Release**. Output: `MissileHoldCam_Engine\bin\Release\MissileHoldCam_Engine.dll`.

Override without a user props file:

```text
msbuild MissileHoldCam_Engine\MissileHoldCam_Engine.csproj /p:Configuration=Release /p:NuclearOptionRoot="D:\Path\To\Nuclear Option"
```

## Pull requests

- Keep changes focused on one feature or fix.
- Match existing code style (no drive-by refactors).
- Update `CHANGELOG.md` and bump version in `MissileHoldCamPlugin.cs` / `AssemblyInfo.cs` when releasing.

## Releases (maintainers)

Attach **`MissileHoldCam_Engine.dll`** (Release build) to the GitHub Release; optionally zip it. Users copy the DLL into `BepInEx\plugins\`.

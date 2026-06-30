**Developer:** Mursisru

# Missile Hold Cam

[![Nuclear Option](https://img.shields.io/badge/Game-Nuclear%20Option-blue)](https://store.steampowered.com/app/2168680/Nuclear_Option/) [![BepInEx 5](https://img.shields.io/badge/Loader-BepInEx%205-orange)](https://docs.bepinex.dev/) [![Version](https://img.shields.io/badge/Version-1.0.2-green)](https://github.com/Mursisru/MissileHoldCam/releases/tag/v1.0.2)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow)](https://github.com/Mursisru/MissileHoldCam/blob/main/LICENSE)


---

## Critical warnings

> [!IMPORTANT]
> **BepInEx 5 (x64) required** - install [BepInEx](https://docs.bepinex.dev/articles/user_guide/installation/index.html) before this mod.

> [!WARNING]
> **Flight controls required** - inactive in map selection, encyclopedia, or TV camera; requires `flightControlsEnabled` and local aircraft as camera target.

> [!NOTE]
> **Hold key is config-only** - not integrated into the game's Rewired keybind screen (default **V** via Configuration Manager).

## Install

> [!IMPORTANT]
> **BepInEx 5 (x64) required** - install [BepInEx](https://docs.bepinex.dev/) before this mod.

1. Get **`MissileHoldCam_Engine.dll`** from Releases or build **Release** yourself.
2. Copy it into `Nuclear Option\BepInEx\plugins\` (create the folder if needed).

## Configuration

- File: `BepInEx\config\com.at747.missileholdcam.cfg`
- **`General.HoldKey`**: `KeyCode` to hold (default **V**). Set via **Configuration Manager** or edit the cfg.
- **`General.PostExplosionHoldSeconds`**: seconds to wait after the missile is gone before restoring your aircraft camera (default **1**; uses unscaled time). **0** = old instant behavior.
- This is **not** integrated into Nuclear Option’s own keybind screen (that would require Rewired/UI work).

## Behavior notes

- Only runs in **SinglePlayer** / **Multiplayer** with **`flightControlsEnabled`**, and not in map **selection**, **encyclopedia**, or **TV** camera states.
- Your **camera follow target** before holding must be your **local aircraft** (`GameManager.IsLocalAircraft`).
- **Which missile:** the **most recently registered** active missile owned by you (salvo: last in the volley).
- If the **missile is destroyed** while holding, the mod **restores** your saved aircraft view.
- Subscribes to **`onRegisterMissile` / `onDeregisterMissile`** on the local `Aircraft` (see `Unit` in game assemblies).

## Repository layout

| Path | Purpose |
|------|---------|
| `MissileHoldCam_Engine/` | Plugin source and `.csproj` |
| `AGENT_CONTEXT.md` | Maintainer / AI session notes (design + reverse-engineering context) |
| `Directory.Build.props` | Default game install path for references |
| `Directory.Build.user.props.example` | Template for a custom game path (gitignored copy: `Directory.Build.user.props`) |

## Manual test checklist

1. Cockpit → launch missile → hold key → orbit on missile; release → cockpit again.
2. Repeat from **chase** / **external orbit** around your plane.
3. Hold until missile hits → camera should return to saved mode.
4. Release key before launch / no missiles → no camera snap.
5. Pause / menu (`flightControlsEnabled` false) → effect stops; release does not fight paused state.
6. Disable mod in config → unload or toggle **Enabled**; no stuck camera (plugin restores on disable/destroy).

## License

[MIT](LICENSE)

## Disclaimer

Fan mod; not affiliated with Nuclear Option’s developers.

## Download

- **Prebuilt:** on GitHub, open **Releases** for this repository and download **`MissileHoldCam_Engine.dll`** (upload it when you cut a release).
- **Source:** clone the repo and build **Release** (see **Build** below).

## Requirements

- Nuclear Option (Steam)
- BepInEx 5 x64
- Optional: **Configuration Manager** (BepInEx) to change the hold key in-game

---

## Keywords

nuclear-option, bepinex, harmony, mod, missileholdcam, csharp, unity

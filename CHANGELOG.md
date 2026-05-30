# Changelog

## 1.0.2 — 2026-05-30

### Performance
- Early idle exit when hold key released; MissileHoldCamConfigCache for config reads.

## 1.0.1 вЂ” 2026-05-09

- After the followed missile is destroyed, the camera **lingers** for **`PostExplosionHoldSeconds`** (default **1** s, unscaled time) before returning to the saved view. Set to **0** for immediate return.

## 1.0.0 вЂ” 2026-05-09

- **Build:** reference `UnityEngine.InputLegacyModule` for `Input.GetKey`. Config **`HoldKey`** is `KeyCode` (not `KeyboardShortcut`) for broader BepInEx/IDE compatibility. Camera state checks use `is Camera*State` patterns.
- Initial release: hold a configurable key (default **V**) to follow your **most recently spawned** missile with the stock orbit camera; release to restore **aircraft + previous camera state** (cockpit / chase / orbit / relative / controlled).
- Missiles tracked via `Unit.onRegisterMissile` / `onDeregisterMissile` on the local aircraft.
- Key binding via **BepInEx Configuration Manager** (`com.at747.missileholdcam.cfg`), not the in-game controls menu.

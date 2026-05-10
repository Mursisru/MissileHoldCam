# Changelog

## 1.1.0

- Takeoff theme plays **once per local aircraft possession**: after landing and taking off again in the **same** aircraft (same instance), the takeoff track no longer retriggers.
- Switching to a **different** aircraft resets the state so the new plane’s first takeoff can still play its theme (when the game requests `takeoffMusic`).
- Only patches `CrossFadeMusic` when the clip matches the current local aircraft’s `takeoffMusic` (avoids touching other cues that share the same bool pattern).

## 1.0.0

- Initial release: Harmony prefix on `MusicManager.CrossFadeMusic` to allow per-aircraft takeoff music on every takeoff (local player).

using BepInEx;
using BepInEx.Configuration;
using UnityEngine;

namespace MissileHoldCam_Engine
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public sealed class MissileHoldCamPlugin : BaseUnityPlugin
    {
        public const string PluginGuid = "com.at747.missileholdcam";
        public const string PluginName = "Missile Hold Cam";
        public const string PluginVersion = "1.0.2";

        internal static MissileHoldCamPlugin Instance { get; private set; }

        internal static ConfigEntry<bool> Enabled { get; private set; }
        internal static ConfigEntry<KeyCode> HoldKey { get; private set; }
        internal static ConfigEntry<float> PostExplosionHoldSeconds { get; private set; }

        private void Awake()
        {
            Instance = this;
            Enabled = Config.Bind("General", "Enabled", true, "Allow hold-to-follow own missile camera.");
            HoldKey = Config.Bind("General", "HoldKey", KeyCode.V,
                "Hold this key to attach the main camera to your latest airborne missile (BepInEx Configuration Manager). Not in the in-game keybind menu.");
            PostExplosionHoldSeconds = Config.Bind("General", "PostExplosionHoldSeconds", 1f,
                "After the missile is destroyed, wait this many seconds (unscaled time) before returning to your aircraft. Set to 0 for instant return.");

            Logger.LogInfo($"{PluginName} {PluginVersion} loaded.");
        }

        private void Update()
        {
            MissileHoldCamController.Tick();
        }

        private void OnDestroy()
        {
            MissileHoldCamController.Shutdown();
        }
    }
}

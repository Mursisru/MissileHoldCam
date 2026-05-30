using UnityEngine;

namespace MissileHoldCam_Engine
{
    internal static class MissileHoldCamConfigCache
    {
        private static int _frame = -1;

        internal static bool Enabled;
        internal static KeyCode HoldKey;
        internal static float PostExplosionHoldSeconds;

        internal static void Refresh()
        {
            int frame = Time.frameCount;
            if (frame == _frame)
                return;
            _frame = frame;

            Enabled = MissileHoldCamPlugin.Enabled != null && MissileHoldCamPlugin.Enabled.Value;
            HoldKey = MissileHoldCamPlugin.HoldKey != null
                ? MissileHoldCamPlugin.HoldKey.Value
                : KeyCode.Mouse1;
            PostExplosionHoldSeconds = MissileHoldCamPlugin.PostExplosionHoldSeconds != null
                ? MissileHoldCamPlugin.PostExplosionHoldSeconds.Value
                : 0f;
        }
    }
}

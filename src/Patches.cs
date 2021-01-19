using Harmony;
using UnityEngine;

namespace ExtremeSnowWalker
{
    internal static class Patches
    {
        [HarmonyPatch(typeof(PlayerMovement),"Update")]
        private static class IncreaseStamina
        {
            internal static void Postfix(PlayerMovement __instance)
            {
                if (Implementation.first_run)
                {
                    Implementation.initial_recovery = __instance.m_SprintStaminaRecoverPerHour;
                    Implementation.initial_seconds_before_recovery = __instance.m_SecondsNotSprintingBeforeRecovery;
                    Implementation.first_run = false;
                }
                __instance.m_SprintStaminaRecoverPerHour = Implementation.initial_recovery * Settings.options.rechargeScalar;
                __instance.m_SecondsNotSprintingBeforeRecovery = Implementation.initial_seconds_before_recovery * Settings.options.secondsScalar;
            }
        }

    }
}
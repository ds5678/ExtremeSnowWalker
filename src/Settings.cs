using ModSettings;

namespace ExtremeSnowWalker
{
    internal class ExtremeSnowWalkerModSettings : JsonModSettings
    {
        [Name("Recharge Multiplier")]
        [Description("Scales the speed at which the stamina bar refills. Snow Walker feat not required.")]
        [Slider(0.2f, 20f, 100)]
        public float rechargeScalar = 1f;

        [Name("Seconds before recovery scalar")]
        [Description("Scales the number of seconds before the stamina bar refills. Snow Walker feat not required.")]
        [Slider(0f, 2f, 21)]
        public float secondsScalar = 1f;
    }
    internal static class Settings
    {
        public static ExtremeSnowWalkerModSettings options;
        public static void OnLoad()
        {
            options = new ExtremeSnowWalkerModSettings();
            options.AddToModSettings("Extreme Snow Walker Settings");
        }
    }
}
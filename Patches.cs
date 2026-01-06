
using Il2CppSystem.Linq.Expressions.Interpreter;

namespace HUDPositioner
{

    internal static class Patches
    {
        [HarmonyPatch(typeof(Panel_PauseMenu),nameof(Panel_PauseMenu.OnDone))]
        
        public class ApplyPositioningWhenChangingHudSize
        {
            public static void Postfix()
            {
                if (HUDPositionerMelon.changedHudScale)
                {
                    HUDPositionerMelon.ApplyPositionSettings();
                    HUDPositionerMelon.changedHudScale = false;
                }

            }
        
        }
        
        [HarmonyPatch(typeof(Panel_OptionsMenu),nameof(Panel_OptionsMenu.ApplyHudSize))]
        
        public class CheckIfChangedHudSize
        {
            public static void Postfix()
            {
                HUDPositionerMelon.changedHudScale = true;
            }
        }


    }
}


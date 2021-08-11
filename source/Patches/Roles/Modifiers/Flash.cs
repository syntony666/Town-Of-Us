using TownOfUs.Extensions;
using TownOfUs.Patches.Language;
using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class Flash : Modifier, IVisualAlteration
    {
        public static float SpeedFactor = 1.23f;

        private static LanguagePack languagePack = new LanguagePack();

        public Flash(PlayerControl player) : base(player)
        {
            Name = languagePack.Flash;
            TaskText = () => languagePack.FlashTaskText;
            Color = new Color(1f, 0.5f, 0.5f, 1f);
            ModifierType = ModifierEnum.Flash;
        }

        public bool TryGetModifiedAppearance(out VisualAppearance appearance)
        {
            appearance = Player.GetDefaultAppearance();
            appearance.SpeedFactor = SpeedFactor;
            return true;
        }
    }
}
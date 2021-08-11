using TownOfUs.Extensions;
using TownOfUs.Patches.Language;
using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class BigBoiModifier : Modifier, IVisualAlteration
    {
        public static float SpeedFactor = 0.7f;
        private static LanguagePack languagePack = new LanguagePack();
        public BigBoiModifier(PlayerControl player) : base(player)
        {
            Name = languagePack.Giant;
            TaskText = () => languagePack.GiantTaskText;
            Color = new Color(1f, 0.5f, 0.5f, 1f);
            ModifierType = ModifierEnum.BigBoi;
        }

        public bool TryGetModifiedAppearance(out VisualAppearance appearance)
        {
            appearance = Player.GetDefaultAppearance();
            appearance.SpeedFactor = SpeedFactor;
            appearance.SizeFactor = new Vector3(1.0f, 1.0f, 1.0f);
            return true;
        }
    }
}
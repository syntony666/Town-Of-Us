using TownOfUs.Patches.Language;
using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class BigBoi : Modifier
    {
        private static LanguagePack languagePack = new LanguagePack();
        public BigBoi(PlayerControl player) : base(player)
        {
            Name = languagePack.Giant;
            TaskText = () => languagePack.GiantTaskText;
            Color = new Color(1f, 0.5f, 0.5f, 1f);
            ModifierType = ModifierEnum.BigBoi;
        }
    }
}
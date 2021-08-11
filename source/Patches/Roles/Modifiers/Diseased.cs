using TownOfUs.Patches.Language;
using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class Diseased : Modifier
    {
        private static LanguagePack languagePack = new LanguagePack();
        public Diseased(PlayerControl player) : base(player)
        {
            Name = languagePack.Diseased;
            TaskText = () => "Killing you gives Impostors a high cooldown";
            Color = Color.grey;
            ModifierType = ModifierEnum.Diseased;
        }
    }
}
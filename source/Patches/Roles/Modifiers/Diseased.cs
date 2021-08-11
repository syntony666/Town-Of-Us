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
            TaskText = () => languagePack.DiseasedTaskText;
            Color = Color.grey;
            ModifierType = ModifierEnum.Diseased;
        }
    }
}
using TownOfUs.Patches.Language;
using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class Drunk : Modifier
    {
        private static LanguagePack languagePack = new LanguagePack();
        public Drunk(PlayerControl player) : base(player)
        {
            Name = languagePack.Drunk;
            TaskText = () => "Inverrrrrted contrrrrols";
            Color = new Color(0.46f, 0.5f, 0f, 1f);
            ModifierType = ModifierEnum.Drunk;
        }
    }
}
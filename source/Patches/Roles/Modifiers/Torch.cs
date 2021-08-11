using TownOfUs.Patches.Language;
using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class Torch : Modifier
    {
        private static LanguagePack languagePack = new LanguagePack();

        public Torch(PlayerControl player) : base(player)
        {
            Name = languagePack.Torch;
            TaskText = () => languagePack.TorchTaskText;
            Color = new Color(1f, 1f, 0.6f);
            ModifierType = ModifierEnum.Torch;
        }
    }
}
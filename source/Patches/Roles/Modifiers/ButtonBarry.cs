using TownOfUs.Patches.Language;
using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class ButtonBarry : Modifier
    {
        public KillButtonManager ButtonButton;

        public bool ButtonUsed;

        private static LanguagePack languagePack = new LanguagePack();

        public ButtonBarry(PlayerControl player) : base(player)
        {
            Name = languagePack.ButtonBarry;
            TaskText = () => languagePack.ButtonBarryTaskText;
            Color = new Color(0.9f, 0f, 1f, 1f);
            ModifierType = ModifierEnum.ButtonBarry;
        }
    }
}
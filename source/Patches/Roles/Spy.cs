using TownOfUs.Patches.Language;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Spy : Role
    {
        private static LanguagePack languagePack = new LanguagePack();

        public Spy(PlayerControl player) : base(player)
        {
            Name = languagePack.Spy;
            ImpostorText = () => "Snoop around and find stuff out";
            TaskText = () => "Spy on people and find the Impostors";
            Color = new Color(0.8f, 0.64f, 0.8f, 1f);
            RoleType = RoleEnum.Spy;
        }
    }
}
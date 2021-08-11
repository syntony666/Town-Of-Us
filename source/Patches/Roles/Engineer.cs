using TownOfUs.Patches.Language;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Engineer : Role
    {
        private static LanguagePack languagePack = new LanguagePack();
        public Engineer(PlayerControl player) : base(player)
        {
            Name = languagePack.Engineer;
            ImpostorText = () => "Maintain important systems on the ship";
            TaskText = () => "Vent and fix a sabotage from anywhere!";
            Color = new Color(1f, 0.65f, 0.04f, 1f);
            RoleType = RoleEnum.Engineer;
        }

        public bool UsedThisRound { get; set; } = false;
    }
}
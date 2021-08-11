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
            ImpostorText = () => languagePack.EngineerImpostorText;
            TaskText = () => languagePack.EngineerTaskText;
            Color = new Color(1f, 0.65f, 0.04f, 1f);
            RoleType = RoleEnum.Engineer;
        }

        public bool UsedThisRound { get; set; } = false;
    }
}
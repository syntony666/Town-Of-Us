using TownOfUs.Patches.Language;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Altruist : Role
    {
        public bool CurrentlyReviving;
        public DeadBody CurrentTarget;

        public bool ReviveUsed;

        private static LanguagePack languagePack = new LanguagePack();

        public Altruist(PlayerControl player) : base(player)
        {
            Name = languagePack.Altruist;
            ImpostorText = () => languagePack.AltruistImpostorText;
            TaskText = () => languagePack.AltruistTaskText;
            Color = new Color(0.4f, 0f, 0f, 1f);
            RoleType = RoleEnum.Altruist;
        }
    }
}
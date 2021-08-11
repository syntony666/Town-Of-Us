using TownOfUs.Patches.Language;
using UnityEngine;

namespace TownOfUs.Roles
{

    public class Medic : Role
    {
        private static LanguagePack languagePack = new LanguagePack();

        public Medic(PlayerControl player) : base(player)
        {
            Name = languagePack.Medic;
            ImpostorText = () => languagePack.MedicImpostorText;
            TaskText = () => languagePack.MedicTaskText;
            Color = new Color(0f, 0.4f, 0f, 1f);
            RoleType = RoleEnum.Medic;
            ShieldedPlayer = null;
        }

        public PlayerControl ClosestPlayer;
        public bool UsedAbility { get; set; } = false;
        public PlayerControl ShieldedPlayer { get; set; }
        public PlayerControl exShielded { get; set; }
    }
}
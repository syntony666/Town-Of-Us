using TownOfUs.ImpostorRoles.UnderdogMod;
using TownOfUs.Patches.Language;

namespace TownOfUs.Roles
{
    public class Underdog : Role
    {
        private static LanguagePack languagePack = new LanguagePack();

        public Underdog(PlayerControl player) : base(player)
        {
            Name = languagePack.Underdog;
            ImpostorText = () => languagePack.UnderdogImpostorText;
            TaskText = () => languagePack.UnderdogTaskText;
            Color = Palette.ImpostorRed;
            RoleType = RoleEnum.Underdog;
            Faction = Faction.Impostors;
        }

        public float MaxTimer() => PlayerControl.GameOptions.KillCooldown * (
            PerformKill.LastImp() ? 0.5f : 1.5f
        );

        public void SetKillTimer()
        {
            Player.SetKillTimer(MaxTimer());
        }
    }
}

using System;
using TownOfUs.Patches.Language;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Shifter : Role
    {
        private static LanguagePack languagePack = new LanguagePack();

        public Shifter(PlayerControl player) : base(player)
        {
            Name = languagePack.Shifter;
            ImpostorText = () => languagePack.ShifterImpostorText;
            TaskText = () => languagePack.ShifterTaskText;
            Color = new Color(0.6f, 0.6f, 0.6f, 1f);
            RoleType = RoleEnum.Shifter;
            Faction = Faction.Neutral;
        }

        public PlayerControl ClosestPlayer;
        public DateTime LastShifted { get; set; }

        public void Loses()
        {
            Player.Data.IsImpostor = true;
        }

        public float ShifterShiftTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastShifted;
            var num = CustomGameOptions.ShifterCd * 1000f;
            var flag2 = num - (float) timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float) timeSpan.TotalMilliseconds) / 1000f;
        }
    }
}
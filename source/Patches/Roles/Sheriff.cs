using System;
using TownOfUs.Patches.Language;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Sheriff : Role
    {
        private static LanguagePack languagePack = new LanguagePack();

        public Sheriff(PlayerControl player) : base(player)
        {
            Name = languagePack.Sheriff;
            ImpostorText = () => languagePack.SheriffImpostorText;
            TaskText = () => languagePack.SheriffTaskText;
            Color = Color.yellow;
            RoleType = RoleEnum.Sheriff;
        }

        public PlayerControl ClosestPlayer;
        public DateTime LastKilled { get; set; }

        public float SheriffKillTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastKilled;
            var num = CustomGameOptions.SheriffKillCd * 1000f;
            var flag2 = num - (float) timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float) timeSpan.TotalMilliseconds) / 1000f;
        }

        internal override bool Criteria()
        {
            return CustomGameOptions.ShowSheriff || base.Criteria();
        }
    }
}
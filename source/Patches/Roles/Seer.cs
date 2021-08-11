using System;
using System.Collections.Generic;
using TownOfUs.CrewmateRoles.SeerMod;
using TownOfUs.Patches.Language;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Seer : Role
    {
        private static LanguagePack languagePack = new LanguagePack();

        public List<byte> Investigated = new List<byte>();

        public Seer(PlayerControl player) : base(player)
        {
            Name = languagePack.Seer;
            ImpostorText = () => languagePack.SeerImpostorText;
            TaskText = () => languagePack.SeerTaskText;
            Color = new Color(1f, 0.8f, 0.5f, 1f);
            RoleType = RoleEnum.Seer;
        }

        public PlayerControl ClosestPlayer;
        public DateTime LastInvestigated { get; set; }

        public float SeerTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastInvestigated;
            var num = CustomGameOptions.SeerCd * 1000f;
            var flag2 = num - (float) timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float) timeSpan.TotalMilliseconds) / 1000f;
        }

        public bool CheckSeeReveal(PlayerControl player)
        {
            var role = GetRole(player);
            switch (CustomGameOptions.SeeReveal)
            {
                case SeeReveal.All:
                    return true;
                case SeeReveal.Nobody:
                    return false;
                case SeeReveal.ImpsAndNeut:
                    return role != null && role.Faction != Faction.Crewmates || player.Data.IsImpostor;
                case SeeReveal.Crew:
                    return role != null && role.Faction == Faction.Crewmates || !player.Data.IsImpostor;
            }

            return false;
        }
    }
}
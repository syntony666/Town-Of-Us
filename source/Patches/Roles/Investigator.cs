using System.Collections.Generic;
using TownOfUs.CrewmateRoles.InvestigatorMod;
using TownOfUs.Patches.Language;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Investigator : Role
    {
        public readonly List<Footprint> AllPrints = new List<Footprint>();

        private static LanguagePack languagePack = new LanguagePack();

        public Investigator(PlayerControl player) : base(player)
        {
            Name = languagePack.Investigator;
            ImpostorText = () => "Find all imposters by examining footprints";
            TaskText = () => "You can see everyone's footprints.";
            Color = new Color(0f, 0.7f, 0.7f, 1f);
            RoleType = RoleEnum.Investigator;
            Scale = 1.4f;
        }
    }
}
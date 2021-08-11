using TownOfUs.Patches.Language;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Impostor : Role
    {
        private static LanguagePack languagePack = new LanguagePack();

        public Impostor(PlayerControl player) : base(player)
        {
            Name = languagePack.ImpostorRoles;
            Hidden = true;
            Faction = Faction.Impostors;
            RoleType = RoleEnum.Impostor;
            Color = Palette.ImpostorRed;
        }
    }

    public class Crewmate : Role
    {
        private static LanguagePack languagePack = new LanguagePack();

        public Crewmate(PlayerControl player) : base(player)
        {
            Name = languagePack.CrewmateRoles;
            Hidden = true;
            Faction = Faction.Crewmates;
            RoleType = RoleEnum.Crewmate;
            Color = Color.white;
        }
    }
}